using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Commands.UpdateStorage
{
    public class UpdateStorageCommand : IRequest
    {
        public StorageEntity Storage { get; set; }
    }
}
