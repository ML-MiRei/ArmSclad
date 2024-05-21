using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.AddOperation
{
    internal class AddOperationHandler(IOperationsRepository operationsRepository) : IRequestHandler<AddOperationCommand, int>
    {
        public Task<int> Handle(AddOperationCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.Add(request.Operation));
        }
    }
}
