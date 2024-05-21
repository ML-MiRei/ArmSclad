using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.UpdateStatusOperation
{
    public class UpdateStatusOperationCommand : IRequest
    {
        public OperationEntity Operation { get; set; }
    }
}
