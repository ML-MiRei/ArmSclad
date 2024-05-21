using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByEmployee
{
    public class GetOperationsByEmployeeQuery : IRequest<List<OperationEntity>>
    {
        public int EmloyeeId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
