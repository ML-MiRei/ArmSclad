using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.AddStorage
{
    internal class AddStorageHandler(IStoragesRepository storagesRepository) : IRequestHandler<AddStorageCommand, int>
    {
        public Task<int> Handle(AddStorageCommand request, CancellationToken cancellationToken)
        {
            return storagesRepository.Add(request.Storage);
        }
    }
}
