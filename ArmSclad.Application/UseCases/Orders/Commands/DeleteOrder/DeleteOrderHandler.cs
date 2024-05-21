using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Orders.Commands.DeleteOrder
{
    internal class DeleteOrderHandler(IOrdersRepository ordersRepository) : IRequestHandler<DeleteOrderCommand>
    {
        public Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => ordersRepository.Delete(request.OrderId));
        }
    }
}
