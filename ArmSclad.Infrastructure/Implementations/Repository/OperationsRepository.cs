using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;


namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class OperationsRepository(DatabaseSingleton db) : IOperationsRepository
    {
        public Task<int> Add(OperationEntity operationEntity)
        {
            var operation = new Operation
            {
                Id = operationEntity.Id,
                Status = operationEntity.Status == null ? (int)OperationStatusEnum.Waiting : (int)operationEntity.Status,
                TargetId = operationEntity.TargetId,
                Type = (int)operationEntity.Type,
                Created = DateTime.Now,
                StorageId = operationEntity.StorageId,
                CreatorId = operationEntity.CreatorId,
                EmployeeId = operationEntity.EmployeeId
            };


            if (!(new OperationTypeEnum[] { OperationTypeEnum.Inventory, OperationTypeEnum.Repackaging, OperationTypeEnum.QualityСontrol }.Contains(operationEntity.Type)) &&
                (OperationStatusEnum)operation.Status == OperationStatusEnum.Waiting)
            {
                operation.Id = db.DbContext.Operations.Max(o => o.Id) + 1;
                db.DbContext.OperationsProducts.AddRange(operationEntity.Products.Select(p => new OperationProduct
                {
                    Amount = p.NumberPackages.Value,
                    OperationId = operation.Id,
                    ProductId = p.Id
                }));
                db.DbContext.SaveChanges();
            }
            else if ((OperationStatusEnum)operation.Status == OperationStatusEnum.Сancelled)
            {
                CancelActionsWithProducts(operationEntity);
            }
            else
            {
                ActionsWithProducts(operationEntity);
            }

            db.DbContext.Operations.Add(operation);
            db.DbContext.SaveChanges();

            return Task.FromResult(operation.Id);
        }


        private void CancelActionsWithProducts(OperationEntity operationEntity)
        {
            switch (operationEntity.Type)
            {
                case OperationTypeEnum.Moving:
                    AddProductsOnStorage(operationEntity);
                    DeleteProductsFromStorage(operationEntity);
                    break;
                case OperationTypeEnum.Acceptance:
                    DeleteProductsFromStorage(operationEntity);
                    break;
                case OperationTypeEnum.Shipment:
                    AddProductsOnStorage(operationEntity);
                    break;
            }
        }

        private void ActionsWithProducts(OperationEntity operationEntity)
        {
            switch (operationEntity.Type)
            {
                case OperationTypeEnum.Moving:
                    DeleteProductsFromStorage(operationEntity);
                    AddProductsOnStorage(operationEntity);
                    break;
                case OperationTypeEnum.Acceptance:
                    AddProductsOnStorage(operationEntity);
                    break;
                case OperationTypeEnum.Shipment:
                    DeleteProductsFromStorage(operationEntity);
                    break;
            }
        }


        private void DeleteProductsFromStorage(OperationEntity operation)
        {
            foreach (var product in operation.Products)
            {
                var stp = db.DbContext.StoragesProducts.First(sp => sp.ProductId == product.Id && sp.StorageId == operation.StorageId);
                stp.Amount -= product.NumberPackages.Value;
                db.DbContext.StoragesProducts.Update(stp);
            }
            db.DbContext.SaveChanges();
        }

        private void AddProductsOnStorage(OperationEntity operation)
        {
            foreach (var product in operation.Products)
            {
                var stp = db.DbContext.StoragesProducts.FirstOrDefault(sp => sp.ProductId == product.Id && sp.StorageId == operation.StorageId);

                // если данного продукта не было на складе добавляем новую запись, иначе - обновляем информацию о количестве
                if (stp == default)
                {
                    db.DbContext.StoragesProducts.Add(new StorageProduct
                    {
                        Amount = product.NumberPackages.Value,
                        ProductId = product.Id,
                        StorageId = operation.StorageId
                    });
                }
                else
                {
                    stp.Amount -= product.NumberPackages.Value;
                    db.DbContext.StoragesProducts.Update(stp);
                }

            }
            db.DbContext.SaveChanges();

        }


        #region gets

        public List<OperationEntity> Get(int from = 0, int to = 10)
        {
            return db.DbContext.Operations.Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type,
                StorageId = o.StorageId,
                CreatorId = o.CreatorId,
                EmployeeId = o.EmployeeId
            }).Skip(from).Take(to).ToList();
        }

        public List<OperationEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.DbContext.Operations.Where(o => o.StorageId == storageId).Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type,
                StorageId = o.StorageId,
                CreatorId = o.CreatorId,
                EmployeeId = o.EmployeeId,
                Products = db.DbContext.Products.Join(
                    db.DbContext.OperationsProducts.Where(op => op.OperationId == o.Id),
                    p => p.Id,
                    op => op.ProductId,
                    (p, op) => new ProductEntity
                    {
                        Id = p.Id,
                        Price = p.Price,
                        SpaceOccupied = p.SpaceOccupied,
                        Description = p.Description,
                        Name = p.Name,
                        NumberPiecesInPackage = p.NumberPiecesInPackage,
                        NumberPackages = db.DbContext.OperationsProducts.First(op => op.ProductId == p.Id && op.OperationId == o.Id).Amount
                    }
                    ).ToList()
            }).Skip(from).Take(to).ToList();
        }

        public List<OperationWithProductEntity> GetByProduct(int productId, int from = 0, int to = 10)
        {
            return db.DbContext.Operations
                .Join(
                db.DbContext.OperationsProducts.Where(p => p.ProductId == productId),
                o => o.Id,
                p => p.OperationId,
                (o, p) =>
                 new OperationWithProductEntity
                 {
                     Id = p.ProductId,
                     Amount = p.Amount,
                     OperationType = (OperationTypeEnum)o.Type,
                     Description = db.DbContext.Products.First(pr => pr.Id == p.ProductId).Description,
                     Name = db.DbContext.Products.First(pr => pr.Id == p.ProductId).Name,
                     TargetId = o.TargetId
                 }).Skip(from).Take(to).ToList();
        }

        #endregion
    }
}
