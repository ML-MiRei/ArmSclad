using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByStorage
{
    internal class GetOperationsByStorageHandler(IOperationsRepository operationsRepository) : IRequestHandler<GetOperationsByStorageQuery, List<OperationEntity>>
    {
        public Task<List<OperationEntity>> Handle(GetOperationsByStorageQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.GetByStorage(request.StorageId, request.From, request.To));
        }
    }
}
