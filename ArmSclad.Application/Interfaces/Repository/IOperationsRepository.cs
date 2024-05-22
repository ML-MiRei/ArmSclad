using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IOperationsRepository
    {
        int Add(OperationEntity operation);
        List<OperationEntity> GetByStorage(int storageId, int from = 0, int to = 10);
        List<OperationEntity> GetByEmployee(int employeeId, int from = 0, int to = 10);
    }
}
