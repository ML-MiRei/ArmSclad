using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Products.Queries.GetProductsByStorage
{
    public class GetProductsByStorageQuery : IRequest<List<ProductEntity>>
    {
        public int StorageId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
