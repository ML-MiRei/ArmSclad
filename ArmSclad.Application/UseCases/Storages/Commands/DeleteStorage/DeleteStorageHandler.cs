using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.DeleteStorage
{
    internal class DeleteStorageHandler(IStoragesRepository storagesRepository) : IRequestHandler<DeleteStorageCommand>
    {
        public Task Handle(DeleteStorageCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => storagesRepository.Delete(request.StorageId));
        }
    }
}
