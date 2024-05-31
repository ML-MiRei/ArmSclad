using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class OrdersRepository(MyDbContext db) : IOrdersRepository
    {
        public Task<int> Add(OrderEntity orderEntity)
        {
            Order order = new Order()
            {
                Address = orderEntity.Address,
                DeliveryTime = orderEntity.DeliveryTime,
                ClientId = orderEntity.Client.Id
            };
            db.Add(order);
            db.SaveChanges();

            foreach (var product in orderEntity.Products)
            {
                db.OrdersProducts.Add(new OrderProduct
                {
                    Amount = product.NumberPackages.Value,
                    OrderId = order.Id,
                    ProductId = product.Id
                });
            }
            db.SaveChanges();

            return Task.FromResult(order.Id);
        }

        public Task Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order != null)
            {
                db.Remove(order);
                db.SaveChanges();
                return Task.CompletedTask;
            }
            throw new NotFoundException();
        }

        public List<OrderEntity> Get(int from = 0, int to = 10)
        {
            return db.Orders.Where(o => o.IsActive).Select(or => new OrderEntity()
            {
                DeliveryTime = or.DeliveryTime,
                Address = or.Address,
                Client = new ClientEntity
                {
                    Id = db.Clients.First(c => c.Id == or.ClientId).Id,
                },
                Id = or.Id,
                Products = db.OrdersProducts
                .Where(op => op.OrderId == or.Id)
                .Join(db.Products, op => op.ProductId, p => p.Id, (op, p) => new ProductEntity
                {
                    Price = p.Price,
                    NumberPackages = op.Amount,
                    Name = p.Name,
                    NumberPiecesInPackage = p.NumberPiecesInPackage,
                }).ToList()

            }).Skip(from).Take(to).ToList();
        }




        public Task Update(OrderEntity orderEntity)
        {

            Order order = db.Orders.Find(orderEntity.Id);
            if (order != null)
            {
                order.Address = orderEntity.Address;
                order.DeliveryTime = orderEntity.DeliveryTime;
                order.ClientId = orderEntity.Client.Id;

                db.Update(order);
                db.SaveChanges();
                return Task.CompletedTask;
            }
            throw new NotFoundException();
        }
    }
}
