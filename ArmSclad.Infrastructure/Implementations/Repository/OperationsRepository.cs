using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Core.Exceptions;
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
                EmployeeId = operationEntity.EmployeeId
            };

            db.DbContext.Operations.Add(operation);
            db.DbContext.SaveChanges();
            return operation.Id;
        }



        public List<OperationEntity> GetByEmployee(int employeeId, int from = 0, int to = 10)
        {
            return db.DbContext.Operations.Where(o => o.Status != (int)OperationStatusEnum.Сancelled && o.EmployeeId == employeeId).Select(o => new OperationEntity
            {
                Id = o.Id,
                Status = (OperationStatusEnum)o.Status,
                TargetId = o.TargetId,
                Type = (OperationTypeEnum)o.Type
            }).Skip(from).Take(to).ToList();
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
