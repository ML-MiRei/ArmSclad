using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.UpdateStatusOperation
{
    internal class UpdateStatusOperationHandler(IOperationsRepository operationsRepository) : IRequestHandler<UpdateStatusOperationCommand>
    {
        public Task Handle(UpdateStatusOperationCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => operationsRepository.Update(request.Operation));
        }
    }
}
