using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IClientsRepository : IBaseRepositoryCommands<ClientEntity>, IBaseRepositoryQueries<ClientEntity>
    { }
}
