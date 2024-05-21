using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProductsByOrder
{
    internal class GetProductsByOrderHandler(IProductsRepository productsRepository) : IRequestHandler<GetProductsByOrderQuery, List<ProductEntity>>
    {
        public Task<List<ProductEntity>> Handle(GetProductsByOrderQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.GetByOrder(request.OrderId, request.From, request.To));
        }
    }
}
