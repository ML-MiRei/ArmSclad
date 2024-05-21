using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.UpdateStorage
{
    internal class UpdateStorageHandler(IStoragesRepository storagesRepository) : IRequestHandler<UpdateStorageCommand>
    {
        public Task Handle(UpdateStorageCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => storagesRepository.Update(request.Storage));
        }
    }
}
