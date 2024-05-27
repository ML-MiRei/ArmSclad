using ArmSclad.Core.Entities;
using ArmSclad.Domain.FiltersModels;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Queries.GetStorages
{
    public class GetStoragesQuery : IRequest<List<StorageEntity>>
    {
        public FilterStorages FilterStorages { get; set; } = null;
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
