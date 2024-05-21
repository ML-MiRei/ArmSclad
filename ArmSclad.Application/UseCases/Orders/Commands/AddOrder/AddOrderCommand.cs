using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.AddOrder
{
    public class AddOrderCommand : IRequest<int>
    {
        public OrderEntity Order { get; set; }
    }
}
