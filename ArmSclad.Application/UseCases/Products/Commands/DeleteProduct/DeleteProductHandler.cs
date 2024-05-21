using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.DeleteProduct
{
    internal class DeleteProductHandler(IProductsRepository productsRepository) : IRequestHandler<DeleteProductCommand>
    {
        public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => productsRepository.Delete(request.ProductId));
        }
    }
}
