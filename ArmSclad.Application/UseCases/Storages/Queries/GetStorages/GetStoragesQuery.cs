using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Queries.GetStorages
{
    public class GetStoragesQuery : IRequest<List<StorageEntity>>
    {
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
