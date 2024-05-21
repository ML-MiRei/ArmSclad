using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.AddStorage
{
    public class AddStorageCommand : IRequest<int>
    {
        public StorageEntity Storage { get; set; }
    }
}
