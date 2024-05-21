using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Queries.GetClients
{
    internal class GetClientsHandler(IClientsRepository clientsRepository) : IRequestHandler<GetClientsQuery, List<ClientEntity>>
    {
        public Task<List<ClientEntity>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => clientsRepository.Get(request.From, request.To));
        }
    }
}
