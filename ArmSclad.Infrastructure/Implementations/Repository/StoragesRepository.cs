using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class StoragesRepository(MyDbContext db) : IStoragesRepository
    {
        public Task<int> Add(StorageEntity storageEntity)
        {
            Storage storage = new Storage
            {
                Address = storageEntity.Address,
                Capacity = storageEntity.Capacity.Value,
                ClosingTime = storageEntity.ClosingTime,
                Name = storageEntity.Name,
                OpeningTime = storageEntity.OpeningTime
            };

            db.Storages.Add(storage);
            db.SaveChanges();
            return Task.FromResult(storage.Id);
        }

        public Task Delete(int id)
        {
            Storage storage = db.Storages.Find(id);
            if (storage != null)
            {
                db.Storages.Remove(storage);
                db.SaveChanges();
                return Task.CompletedTask; 
            }
            throw new NotFoundException();

        }

        public List<StorageEntity> Get(int from = 0, int to = 10)
        {

            return db.Storages.Where(s => s.IsActive).OrderBy(s => s.Name).Select(s => new StorageEntity
            {
                Address = s.Address,
                Capacity = s.Capacity,
                ClosingTime = s.ClosingTime,
                OpeningTime = s.OpeningTime,
                Id = s.Id,
                Name = s.Name,
                Products = db.StoragesProducts
                .Where(sp => sp.StorageId == s.Id)
                .Join(db.Products, sp => sp.ProductId, p => p.Id, (sp, p) =>
                    new ProductEntity
                    {
                        Price = p.Price,
                        Description = p.Description,
                        Name = p.Name,
                        SpaceOccupied = p.SpaceOccupied,
                        Id = p.Id,
                        NumberPackages = sp.Amount,
                        NumberPiecesInPackage = p.NumberPiecesInPackage
                    }).ToList()

            }).Skip(from).Take(to).ToList();
        }



        public List<StorageEntity> Get(Domain.FiltersModels.FilterStorages filterStorages, int from, int to)
        {

            var storages = db.Storages.Where(s => s.IsActive);

            if (filterStorages.SearchName != null)
                storages = storages.Where(s => s.Name.Contains(filterStorages.SearchName));

            if (filterStorages.MaxCapacity != null)
                storages = storages.Where(s => s.Capacity <= filterStorages.MaxCapacity);

            if (filterStorages.MinCapacity != null)
                storages = storages.Where(s => s.Capacity >= filterStorages.MinCapacity);

            if (filterStorages.WorkTime != null)
                storages = storages.Where(s => s.OpeningTime.TimeOfDay <= filterStorages.WorkTime.Value.TimeOfDay && s.ClosingTime.TimeOfDay >= filterStorages.WorkTime.Value.TimeOfDay);


            return storages.OrderBy(s => s.Name).Select(s => new StorageEntity
            {
                Address = s.Address,
                Capacity = s.Capacity,
                ClosingTime = s.ClosingTime,
                OpeningTime = s.OpeningTime,
                Id = s.Id,
                Name = s.Name
            }).Skip(from).Take(to).ToList(); ;

        }

        public Task Update(StorageEntity storageEntity)
        {
            Storage storage = db.Storages.Find(storageEntity.Id);
            if (storage != null)
            {
                storage.Address = storageEntity.Address;
                storage.Capacity = storageEntity.Capacity.Value;
                storage.ClosingTime = storageEntity.ClosingTime;
                storage.Name = storageEntity.Name;
                storage.OpeningTime = storageEntity.OpeningTime;

                db.Storages.Update(storage);
                db.SaveChanges();
                return Task.CompletedTask;
            }
            throw new NotFoundException();
        }
    }
}
