using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int ProductId { get; set; }
    }
}
