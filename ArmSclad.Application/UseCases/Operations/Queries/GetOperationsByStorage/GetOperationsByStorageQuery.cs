using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByStorage
{
    public class GetOperationsByStorageQuery : IRequest<List<OperationEntity>>
    {
        public int StorageId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
