using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.DeleteClient
{
    public class DeleteClientHandler(IClientsRepository clientsRepository) : IRequestHandler<DeleteClientCommand>
    {
        public Task Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => clientsRepository.Delete(request.ClientId));
        }
    }
}
