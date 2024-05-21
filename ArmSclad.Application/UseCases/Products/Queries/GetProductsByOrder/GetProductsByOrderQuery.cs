using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProductsByOrder
{
    public class GetProductsByOrderQuery : IRequest<List<ProductEntity>>
    {
        public int OrderId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
