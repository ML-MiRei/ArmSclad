using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class OrdersRepository(DatabaseSingleton db) : IOrdersRepository
    {
        public int Add(OrderEntity orderEntity)
        {
            Order order = new Order()
            {
                Address = orderEntity.Address,
                DeliveryTime = orderEntity.DeliveryTime,
                ClientId = orderEntity.Client.Id
            };
            db.DbContext.Add(order);
            db.DbContext.SaveChanges();

            foreach (var product in orderEntity.Products)
            {
                db.DbContext.OrdersProducts.Add(new OrderProduct
                {
                    Amount = product.NumberPackages.Value,
                    OrderId = order.Id,
                    ProductId = product.Id
                });
            }
            db.DbContext.SaveChanges();

            return order.Id;
        }

        public void Delete(int id)
        {
            Order order = db.DbContext.Orders.Find(id);
            if (order != null)
            {
                db.DbContext.Remove(order);
                db.DbContext.SaveChanges();
                return;
            }
            throw new NotFoundException();
        }

        public List<OrderEntity> Get(int from = 0, int to = 10)
        {
            return db.DbContext.Orders.Where(o => o.IsActive).Select(or => new OrderEntity()
            {
                DeliveryTime = or.DeliveryTime,
                Address = or.Address,
                Client = new ClientEntity
                {
                    Id = db.DbContext.Clients.First(c => c.Id == or.ClientId).Id,
                },
                Id = or.Id,
                Products = db.DbContext.OrdersProducts
                .Where(op => op.OrderId == or.Id)
                .Join(db.DbContext.Products, op => op.ProductId, p => p.Id, (op, p) => new ProductEntity
                {
                    Price = p.Price,
                    NumberPackages = op.Amount,
                    Name = p.Name,
                    NumberPiecesInPackage = p.NumberPiecesInPackage,
                }).ToList()

            }).Skip(from).Take(to).ToList();
        }




        public void Update(OrderEntity orderEntity)
        {

            Order order = db.DbContext.Orders.Find(orderEntity.Id);
            if (order != null)
            {
                order.Address = orderEntity.Address;
                order.DeliveryTime = orderEntity.DeliveryTime;
                order.ClientId = orderEntity.Client.Id;

                db.DbContext.Update(order);
                db.DbContext.SaveChanges();
                return;
            }
            throw new NotFoundException();
        }
    }
}
