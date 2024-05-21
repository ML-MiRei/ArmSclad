using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Commands.AddProduct
{
    public class AddProductCommand : IRequest<int>
    {
        public ProductEntity Product { get; set; }
    }
}
