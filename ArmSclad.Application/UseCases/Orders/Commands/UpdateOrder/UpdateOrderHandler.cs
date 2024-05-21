using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.UpdateOrder
{
    internal class UpdateOrderHandler(IOrdersRepository ordersRepository) : IRequestHandler<UpdateOrderCommand>
    {
        public Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => ordersRepository.Update(request.Order));
        }
    }
}
