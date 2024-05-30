using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperations
{
    public class GetOperationsQuery : IRequest<List<OperationEntity>>
    {
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
