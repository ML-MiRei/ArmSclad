using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        public OrderEntity Order { get; set; }
    }
}
