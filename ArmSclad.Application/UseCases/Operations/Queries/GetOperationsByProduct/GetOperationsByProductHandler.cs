using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByProduct
{
    public class GetOperationsByProductHandler(IOperationsRepository operationsRepository) : 
        IRequestHandler<GetOperationsByProductQuery, List<OperationWithProductEntity>>
    {
        public Task<List<OperationWithProductEntity>> Handle(GetOperationsByProductQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.GetByProduct(request.ProductId, request.From, request.To));
        }
    }
}
