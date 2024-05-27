using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProducts
{
    internal class GetProductsHandler(IProductsRepository productsRepository) : IRequestHandler<GetProductsQuery, List<ProductEntity>>
    {
        public Task<List<ProductEntity>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.Get(request.From, request.To));
        }
    }
}
