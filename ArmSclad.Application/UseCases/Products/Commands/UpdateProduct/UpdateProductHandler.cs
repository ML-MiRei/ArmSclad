using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.UpdateProduct
{
    internal class UpdateProductHandler(IProductsRepository productsRepository) : IRequestHandler<UpdateProductCommand>
    {
        public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.Update(request.Product));
        }
    }
}
