using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class OperationsRepository(DatabaseSingleton db) : IOperationsRepository
    {
        public int Add(OperationEntity operationEntity)
        {
            var operation = new Operation
            {
                Status = (int)OperationStatusEnum.Waiting,
                TargetId = operationEntity.TargetId,
                Type = (int)operationEntity.Type,
                Created = DateTime.Now,
                StorageId = operationEntity.StorageId,
                CreatorId = operationEntity.CreatorId,
            };

            db.DbContext.Operations.Add(operation);
            db.DbContext.SaveChanges();

            db.DbContext.OperationsProducts.AddRange(operationEntity.Products.Select(p => new OperationProduct
            {
                Amount = p.NumberPackagesOnStorage.Value,
                OperationId = operation.Id,
                ProductId = p.Id
            }));
            db.DbContext.SaveChanges();

            return operation.Id;
        }


        public List<OperationEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.DbContext.Operations.Where(o => o.StorageId == storageId).Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type
            }).Skip(from).Take(to).ToList();
        }

    }
}
