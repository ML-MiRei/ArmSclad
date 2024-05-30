using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByProduct
{
    public class GetOperationsByProductQuery : IRequest<List<OperationWithProductEntity>>
    {
        public int ProductId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
