using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.CancelOperation
{
    public class CancelOperationCommand : IRequest
    {
        public int OperationId { get; set; }
    }
}
