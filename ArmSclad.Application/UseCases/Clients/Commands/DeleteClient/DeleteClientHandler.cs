using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.DeleteClient
{
    internal class DeleteClientHandler(IClientsRepository clientsRepository) : IRequestHandler<DeleteClientCommand>
    {
        public Task Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => clientsRepository.Delete(request.ClientEntity.Id));
        }
    }
}
