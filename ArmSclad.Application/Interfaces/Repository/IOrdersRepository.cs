using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IOrdersRepository : IBaseRepositoryCommands<OrderEntity>, IBaseRepositoryQueries<OrderEntity>
    { }
}
