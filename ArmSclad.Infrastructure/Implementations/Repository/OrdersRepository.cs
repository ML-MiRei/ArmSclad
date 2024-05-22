using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ClientId = orderEntity.ClientId
            };
            db.DbContext.Add(order);
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
                ClientId = or.ClientId,
                Id = or.Id
              
            }).Skip(from).Take(to).ToList();
        }

        public void Update(OrderEntity orderEntity)
        {

            Order order = db.DbContext.Orders.Find(orderEntity.Id);
            if (order != null)
            {
                order.Address = orderEntity.Address;
                order.DeliveryTime = orderEntity.DeliveryTime;
                order.ClientId = orderEntity.ClientId;

                db.DbContext.Update(order);
                db.DbContext.SaveChanges();
                return;
            }
            throw new NotFoundException();
        }
    }
}
