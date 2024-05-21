using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public int OrderId { get; set; }
    }
}
