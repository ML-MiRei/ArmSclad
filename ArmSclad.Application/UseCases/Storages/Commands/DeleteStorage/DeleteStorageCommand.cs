using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.DeleteStorage
{
    public class DeleteStorageCommand : IRequest
    {
        public int StorageId { get; set; }
    }
}
