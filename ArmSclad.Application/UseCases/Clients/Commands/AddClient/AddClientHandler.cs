using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.AddClient
{
    internal class AddClientHandler(IClientsRepository clientsRepository) : IRequestHandler<AddClientCommand, int>
    {
        public Task<int> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            return clientsRepository.Add(request.ClientEntity);
        }
    }
}
