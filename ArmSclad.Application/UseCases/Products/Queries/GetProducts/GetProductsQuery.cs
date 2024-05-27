using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<List<ProductEntity>>
    {
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
