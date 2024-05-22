using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Infrastructure.Database.Context;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class ClientsRepository(DatabaseSingleton db) : IClientsRepository
    {
        public int Add(ClientEntity clientEntity)
        {
            var client = new Database.Model.Client
            {
                FirstName = clientEntity.FirstName,
                LastName = clientEntity.LastName,
                SecondName = clientEntity.SecondName,
                Address = clientEntity.Address,
                Email = clientEntity.Email,
                Phone = clientEntity.Phone,
                Status = (int)clientEntity.Status,
                IsActive = true
            };

             db.DbContext.Clients.Add(client);
             db.DbContext.SaveChanges();

            return client.Id;
        }

        public void Delete(int id)
        {
            var client = db.DbContext.Clients.Find(id);
            if (client != null)
            {
                db.DbContext.Clients.Remove(client);
                db.DbContext.SaveChanges();
                return;
            }
            throw new NotFoundException();

        }

        public List<ClientEntity> Get(int from = 0, int to = 10)
        {
            return db.DbContext.Clients.Where(c => c.IsActive).Select(c => new ClientEntity
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                SecondName = c.SecondName,
                Address = c.Address,
                Email = c.Email,
                Phone = c.Phone,
                Status = (Core.Enums.ClientStatusEnum)c.Status
            }).Skip(from).Take(to).ToList();
        }

        public void Update(ClientEntity clientEntity)
        {
            var client = db.DbContext.Clients.Find(clientEntity.Id);
            if (client != null)
            {

                client.Address = clientEntity.Address;
                client.Email = clientEntity.Email;
                client.Phone = clientEntity.Phone;
                client.FirstName = clientEntity.FirstName;
                client.SecondName = clientEntity.SecondName;
                client.LastName = clientEntity.LastName;
                client.Status = (int)clientEntity.Status;

                db.DbContext.Clients.Update(client);
                db.DbContext.SaveChanges();
                return;
            }
            throw new NotFoundException();

        }
    }
}
