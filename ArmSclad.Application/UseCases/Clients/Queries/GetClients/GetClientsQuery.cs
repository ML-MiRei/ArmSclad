using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Queries.GetClients
{
    public class GetClientsQuery : IRequest<List<ClientEntity>>
    {
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
