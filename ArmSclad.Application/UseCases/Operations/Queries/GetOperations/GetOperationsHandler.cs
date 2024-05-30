using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperations
{
    internal class GetOperationsHandler(IOperationsRepository operationsRepository) : IRequestHandler<GetOperationsQuery, List<OperationEntity>>
    {
        public Task<List<OperationEntity>> Handle(GetOperationsQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.Get(request.From, request.To));
        }
    }
}
