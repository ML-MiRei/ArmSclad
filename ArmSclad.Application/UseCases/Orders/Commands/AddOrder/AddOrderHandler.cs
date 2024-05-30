using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.AddOrder
{
    public class AddOrderHandler(IOrdersRepository ordersRepository) : IRequestHandler<AddOrderCommand, int>
    {
        public Task<int> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => ordersRepository.Add(request.Order));
        }
    }
}
