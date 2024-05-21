using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest
    {
        public ProductEntity Product { get; set; }
    }
}
