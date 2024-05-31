using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Infrastructure.Database.Context;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class ClientsRepository(MyDbContext db) : IClientsRepository
    {
        public Task<int> Add(ClientEntity clientEntity)
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

            db.Clients.Add(client);
            db.SaveChanges();

            return Task.FromResult(client.Id);
        }

        public Task Delete(int id)
        {
            var client = db.Clients.Find(id);
            if (client != null)
            {
                db.Clients.Remove(client);
                db.SaveChanges();
                return Task.CompletedTask;
            }
            throw new NotFoundException();

        }

        public List<ClientEntity> Get(int from = 0, int to = 10)
        {
            return db.Clients.Where(c => c.IsActive).Select(c => new ClientEntity
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

        public Task Update(ClientEntity clientEntity)
        {
            var client = db.Clients.Find(clientEntity.Id);
            if (client != null)
            {

                client.Address = clientEntity.Address;
                client.Email = clientEntity.Email;
                client.Phone = clientEntity.Phone;
                client.FirstName = clientEntity.FirstName;
                client.SecondName = clientEntity.SecondName;
                client.LastName = clientEntity.LastName;
                client.Status = (int)clientEntity.Status;

                db.Clients.Update(client);
                db.SaveChanges();
                return Task.CompletedTask;
            }
            throw new NotFoundException();

        }
    }
}
