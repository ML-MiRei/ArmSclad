using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.UpdateClient
{
    internal class UpdateClientHandler(IClientsRepository clientsRepository) : IRequestHandler<UpdateClientCommand>
    {
        public Task Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => clientsRepository.Update(request.ClientEntity));
        }
    }
}
