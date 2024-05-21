using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByEmployee
{
    internal class GetOperationsByEmployeeHandler(IOperationsRepository operationsRepository) : IRequestHandler<GetOperationsByEmployeeQuery, List<OperationEntity>>
    {
        public Task<List<OperationEntity>> Handle(GetOperationsByEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.GetByEmployee(request.EmloyeeId, request.From, request.To));
        }
    }
}
