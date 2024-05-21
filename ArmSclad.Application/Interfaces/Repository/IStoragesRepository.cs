using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IStoragesRepository : IBaseRepositoryCommands<StorageEntity>, IBaseRepositoryQueries<StorageEntity>
    { }
}
