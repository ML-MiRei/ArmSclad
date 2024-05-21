using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProductsByStorage
{
    internal class GetProductsByStorageHandler(IProductsRepository productsRepository) : IRequestHandler<GetProductsByStorageQuery, List<ProductEntity>>
    {
        public Task<List<ProductEntity>> Handle(GetProductsByStorageQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.GetByStorage(request.StorageId, request.From, request.To));
        }
    }
}
