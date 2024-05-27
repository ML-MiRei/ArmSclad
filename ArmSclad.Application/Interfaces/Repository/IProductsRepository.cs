using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IProductsRepository : IBaseRepositoryCommands<ProductEntity>, IBaseRepositoryQueries<ProductEntity>
    {
        public List<ProductEntity> GetByOrder(int orderId, int from = 0, int to = 10);
        public List<ProductEntity> GetByStorage(int storageId, int from = 0, int to = 10);


    }
}
