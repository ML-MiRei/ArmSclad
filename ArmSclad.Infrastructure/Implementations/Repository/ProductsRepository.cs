using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class ProductsRepository(MyDbContext db) : IProductsRepository
    {
        public Task<int> Add(ProductEntity productEntity)
        {
            Product product = new Product()
            {
                Description = productEntity.Description,
                Name = productEntity.Name,
                NumberPiecesInPackage = productEntity.NumberPiecesInPackage.Value,
                Price = productEntity.Price.Value,
                SpaceOccupied = productEntity.SpaceOccupied.Value
            };

            db.Products.Add(product);
            db.SaveChanges();
            return Task.FromResult(product.Id);
        }

        public Task Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Task.CompletedTask;
            }

            throw new NotFoundException();
        }

        public List<ProductEntity> Get(int from = 0, int to = 10)
        {
            return db.Products.Where(p => p.IsActive).OrderBy(p => p.Name).Select(p =>
            new ProductEntity
            {
                Description = p.Description,
                Name = p.Name,
                SpaceOccupied = p.SpaceOccupied,
                Id = p.Id,
                Price = p.Price,
                NumberPiecesInPackage = p.NumberPiecesInPackage,
            }).Skip(from).Take(to).ToList();
        }

        public List<ProductEntity> GetByOrder(int orderId, int from = 0, int to = 10)
        {
            return db.Products.Join(
                db.OrdersProducts.Where(ord => ord.OrderId == orderId),
                p => p.Id,
                o => o.ProductId,
                (p, o) => new ProductEntity
                {
                    Description = p.Description,
                    Name = p.Name,
                    SpaceOccupied = p.SpaceOccupied,
                    Id = p.Id,
                    Price = p.Price,
                    NumberPiecesInPackage = p.NumberPiecesInPackage,
                    NumberPackages = db.OrdersProducts.First(op => op.OrderId == orderId && op.ProductId == p.Id).Amount
                }).Skip(from).Take(to).ToList();
        }

        public List<ProductEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.Products.Join(
               db.StoragesProducts.Where(stg => stg.StorageId == storageId),
               p => p.Id,
               o => o.ProductId,
               (p, o) => new ProductEntity
               {
                   Description = p.Description,
                   Name = p.Name,
                   SpaceOccupied = p.SpaceOccupied,
                   Id = p.Id,
                   Price = p.Price,
                   NumberPiecesInPackage = p.NumberPiecesInPackage,
                   NumberPackages = db.StoragesProducts.First(sp => sp.StorageId == storageId && sp.ProductId == p.Id).Amount
               }).Skip(from).Take(to).ToList();
        }

        public Task Update(ProductEntity productEntity)
        {
            Product product = db.Products.Find(productEntity.Id);
            if (product != null)
            {
                product.Description = productEntity.Description;
                product.Price = productEntity.Price.Value;
                product.SpaceOccupied = productEntity.SpaceOccupied.Value;
                product.Name = productEntity.Name;
                product.NumberPiecesInPackage = productEntity.NumberPiecesInPackage.Value;

                db.Products.Update(product);
                db.SaveChanges();
                return Task.CompletedTask;
            }

            throw new NotFoundException();
        }
    }
}
