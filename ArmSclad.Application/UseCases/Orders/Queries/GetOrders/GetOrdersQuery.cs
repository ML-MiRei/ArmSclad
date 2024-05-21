using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Queries.GetOrders
{
    public class GetOrdersQuery : IRequest<List<OrderEntity>>
    {
        public int From { get; set; }
        public int To { get; set; }
    }
}
