using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;


namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class OperationsRepository(MyDbContext db) : IOperationsRepository
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
                operation.Id = db.Operations.Max(o => o.Id) + 1;
                db.OperationsProducts.AddRange(operationEntity.Products.Select(p => new OperationProduct
                {
                    Amount = p.NumberPackages.Value,
                    OperationId = operation.Id,
                    ProductId = p.Id
                }));
                db.SaveChanges();
            }

            if ((OperationStatusEnum)operation.Status == OperationStatusEnum.Сancelled)
            {
                CancelActionsWithProducts(operationEntity);
            }
            else
            {
                ActionsWithProducts(operationEntity);
            }

            db.Operations.Add(operation);
            db.SaveChanges();

            return Task.FromResult(operation.Id);
        }


        private void CancelActionsWithProducts(OperationEntity operationEntity)
        {
            switch (operationEntity.Type)
            {
                case OperationTypeEnum.Moving:
                    AddProductsOnStorage(operationEntity, operationEntity.StorageId);
                    DeleteProductsFromStorage(operationEntity, operationEntity.TargetId.Value);
                    break;
                case OperationTypeEnum.Acceptance:
                    DeleteProductsFromStorage(operationEntity, operationEntity.StorageId);
                    break;
                case OperationTypeEnum.Shipment:
                    AddProductsOnStorage(operationEntity, operationEntity.StorageId);
                    break;
            }
        }

        private void ActionsWithProducts(OperationEntity operationEntity)
        {
            switch (operationEntity.Type)
            {
                case OperationTypeEnum.Moving:
                    DeleteProductsFromStorage(operationEntity, operationEntity.StorageId);
                    AddProductsOnStorage(operationEntity, operationEntity.TargetId.Value);
                    break;
                case OperationTypeEnum.Acceptance:
                    AddProductsOnStorage(operationEntity, operationEntity.StorageId);
                    break;
                case OperationTypeEnum.Shipment:
                    DeleteProductsFromStorage(operationEntity, operationEntity.StorageId);
                    break;
            }
        }


        private void DeleteProductsFromStorage(OperationEntity operation, int storageId)
        {
            foreach (var product in operation.Products)
            {
                var stp = db.StoragesProducts.First(sp => sp.ProductId == product.Id && sp.StorageId == storageId);
                stp.Amount -= product.NumberPackages.Value;
                db.StoragesProducts.Update(stp);
            }
            db.SaveChanges();
        }

        private void AddProductsOnStorage(OperationEntity operation, int storageId)
        {
            foreach (var product in operation.Products)
            {
                var stp = db.StoragesProducts.FirstOrDefault(sp => sp.ProductId == product.Id && sp.StorageId == storageId);

                // если данного продукта не было на складе добавляем новую запись, иначе - обновляем информацию о количестве
                if (stp == default)
                {
                    db.StoragesProducts.Add(new StorageProduct
                    {
                        Amount = product.NumberPackages.Value,
                        ProductId = product.Id,
                        StorageId = storageId
                    });
                }
                else
                {
                    stp.Amount += product.NumberPackages.Value;
                    db.StoragesProducts.Update(stp);
                }

            }
            db.SaveChanges();

        }


        #region gets

        public List<OperationEntity> Get(int from = 0, int to = 10)
        {
            return db.Operations.Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type,
                StorageId = o.StorageId,
                CreatorId = o.CreatorId,
                EmployeeId = o.EmployeeId,
                Products = db.Products.Join(
                    db.OperationsProducts.Where(op => op.OperationId == o.Id),
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
                        NumberPackages = db.OperationsProducts.First(op => op.ProductId == p.Id && op.OperationId == o.Id).Amount
                    }
                    ).ToList()
            }).Skip(from).Take(to).ToList();
        }

        public List<OperationEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.Operations.Where(o => o.StorageId == storageId).Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type,
                StorageId = o.StorageId,
                CreatorId = o.CreatorId,
                EmployeeId = o.EmployeeId,
                Products = db.Products.Join(
                    db.OperationsProducts.Where(op => op.OperationId == o.Id),
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
                        NumberPackages = db.OperationsProducts.First(op => op.ProductId == p.Id && op.OperationId == o.Id).Amount
                    }
                    ).ToList()
            }).Skip(from).Take(to).ToList();
        }

        public List<OperationWithProductEntity> GetByProduct(int productId, int from = 0, int to = 10)
        {
            return db.Operations
                .Join(
                db.OperationsProducts.Where(p => p.ProductId == productId),
                o => o.Id,
                p => p.OperationId,
                (o, p) =>
                 new OperationWithProductEntity
                 {
                     Id = p.ProductId,
                     Amount = p.Amount,
                     OperationType = (OperationTypeEnum)o.Type,
                     Description = db.Products.First(pr => pr.Id == p.ProductId).Description,
                     Name = db.Products.First(pr => pr.Id == p.ProductId).Name,
                     TargetId = o.TargetId
                 }).Skip(from).Take(to).ToList();
        }

        #endregion
    }
}
