using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.CancelOperation
{
    internal class CancelOperationHandler(IOperationsRepository operationsRepository) : IRequestHandler<CancelOperationCommand>
    {
        public Task Handle(CancelOperationCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.Delete(request.OperationId));
        }

    }
}