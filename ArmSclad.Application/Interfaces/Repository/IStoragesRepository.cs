using ArmSclad.Core.Entities;
using ArmSclad.Domain.FiltersModels;
using ArmSclad.Domain.UseCases.Clients.Queries.GetClients;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IStoragesRepository : IBaseRepositoryCommands<StorageEntity>, IBaseRepositoryQueries<StorageEntity>
    {
        List<StorageEntity> Get(FilterStorages filterStorages, int from, int to);
    }
}
