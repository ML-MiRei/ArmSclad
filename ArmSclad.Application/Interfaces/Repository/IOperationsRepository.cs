using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IOperationsRepository : IBaseRepositoryQueries<OperationEntity>
    {
        Task<int> Add(OperationEntity operation);
        List<OperationEntity> GetByStorage(int storageId, int from = 0, int to = 10);
        List<OperationWithProductEntity> GetByProduct(int productId, int from = 0, int to = 10);
    }
}
