using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.AddProduct
{
    internal class AddProductHandler(IProductsRepository productsRepository) : IRequestHandler<AddProductCommand, int>
    {
        public Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.Add(request.Product));
        }
    }
}
