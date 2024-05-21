using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Queries.GetOrders
{
    internal class GetOrdersHandler(IOrdersRepository ordersRepository) : IRequestHandler<GetOrdersQuery, List<OrderEntity>>
    {
        public Task<List<OrderEntity>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => ordersRepository.Get(request.From, request.To));
        }
    }
}
