using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Exceptions;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;
using System.Diagnostics;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class ProductsRepository(DatabaseSingleton db) : IProductsRepository
    {
        public int Add(ProductEntity productEntity)
        {
            Product product = new Product()
            {
                Description = productEntity.Description,
                Name = productEntity.Name,
                NumberPiecesInPackage = productEntity.NumberPiecesInPackage.Value,
                Price = productEntity.Price.Value,
                SpaceOccupied = productEntity.SpaceOccupied.Value
            };

            db.DbContext.Products.Add(product);
            db.DbContext.SaveChanges();
            return product.Id;
        }

        public void Delete(int id)
        {
            Product product = db.DbContext.Products.Find(id);
            if (product != null)
            {
                db.DbContext.Products.Remove(product);
                db.DbContext.SaveChanges();
                return;
            }

            throw new NotFoundException();
        }

        public List<ProductEntity> Get(int from = 0, int to = 10)
        {
            return db.DbContext.Products.Where(p => p.IsActive).OrderBy(p => p.Name).Select(p => 
            new ProductEntity
            {
                Description = p.Description,
                Name = p.Name,
                SpaceOccupied = p.SpaceOccupied,
                Id = p.Id,
                Price = p.Price,
                NumberPiecesInPackage = p.NumberPiecesInPackage
            }).Skip(from).Take(to).ToList();
        }

        public List<ProductEntity> GetByOrder(int orderId, int from = 0, int to = 10)
        {
            return db.DbContext.Products.Join(
                db.DbContext.OrdersProducts.Where(ord => ord.OrderId == orderId),
                p => p.Id,
                o => o.ProductId,
                (p, o) => new ProductEntity
                {
                    Description = p.Description,
                    Name = p.Name,
                    SpaceOccupied = p.SpaceOccupied,
                    Id = p.Id,
                    Price = p.Price,
                    NumberPiecesInPackage = p.NumberPiecesInPackage
                }).Skip(from).Take(to).ToList();
        }

        public List<ProductEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.DbContext.Products.Join(
               db.DbContext.StoragesProducts.Where(stg => stg.StorageId == storageId),
               p => p.Id,
               o => o.ProductId,
               (p, o) => new ProductEntity
               {
                   Description = p.Description,
                   Name = p.Name,
                   SpaceOccupied = p.SpaceOccupied,
                   Id = p.Id,
                   Price = p.Price,
                   NumberPiecesInPackage = p.NumberPiecesInPackage
               }).Skip(from).Take(to).ToList();
        }

        public void Update(ProductEntity productEntity)
        {
            Product product = db.DbContext.Products.Find(productEntity.Id);
            if (product != null)
            {
                product.Description = productEntity.Description;
                product.Price = productEntity.Price.Value;
                product.SpaceOccupied = productEntity.SpaceOccupied.Value;
                product.Name = productEntity.Name;
                product.NumberPiecesInPackage = productEntity.NumberPiecesInPackage.Value;

                db.DbContext.Products.Update(product);
                db.DbContext.SaveChanges();
                return;
            }

            throw new NotFoundException();
        }
    }
}
