using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Operations.Commands.AddOperation
{
    public class AddOperationCommand : IRequest<int>
    {
        public OperationEntity Operation { get; set; }
    }
}
