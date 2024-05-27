using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Implementations.Repository;
using ArmSclad.Infrastructure.Implementations.Services;

namespace Tests
{
    [TestClass]
    public class DbRepositoryTest
    {
        static DatabaseSingleton databaseSingleton = new DatabaseSingleton();
       

        [TestMethod]
        public async Task TestClientAsync()
        {
            ClientsRepository clientsRepository = new ClientsRepository(databaseSingleton);
            ClientEntity client = new ClientEntity
            {
                Address = "Test",
                Email = "Test",
                FirstName = "Test",
                LastName = "Test",
                SecondName = "Test",
                Phone = "Test",
                Status = (int)ClientStatusEnum.PhysicalPerson
            };

            var resultInsert = clientsRepository.Add(client);
            client.Id = resultInsert;

            Assert.IsNotNull(resultInsert);

            client.Email = "Test2";
            clientsRepository.Update(client);
            var resultUpdate = databaseSingleton.DbContext.Clients.Find(resultInsert).Email;

            Assert.IsTrue(resultUpdate == client.Email);

            clientsRepository.Delete(resultInsert);
            var resultDelete = databaseSingleton.DbContext.Clients.Find(client.Id).IsActive;
            Assert.IsFalse(resultDelete);
        }


        [TestMethod]
        public async Task TestStorageAsync()
        {

            StoragesRepository storagesRepository = new StoragesRepository(databaseSingleton);
            StorageEntity storage = new  StorageEntity
            {
                Address = "Test",
                Capacity = 100,
                ClosingTime = DateTime.Now,
                Name = "Test",
                OpeningTime = DateTime.Now
            };

            var resultInsert = storagesRepository.Add(storage);
            storage.Id = resultInsert;
            Assert.IsNotNull(resultInsert);

            storage.Name = "Test2";
            storagesRepository.Update(storage);
            var resultUpdate = databaseSingleton.DbContext.Storages.Find(resultInsert).Name;

            Assert.IsTrue(resultUpdate == storage.Name);

            storagesRepository.Delete(resultInsert);
            var resultDelete = databaseSingleton.DbContext.Storages.Find(resultInsert).IsActive;
            Assert.IsFalse(resultDelete);
        }


        [TestMethod]
        public async Task TestOperationsAsync()
        {

            OperationsRepository operationsRepository = new OperationsRepository(databaseSingleton);
            OperationEntity operation = new OperationEntity
            {
                CreatorId = 0,
                EmployeeId = 0,
                StorageId = 0,
                Type = OperationTypeEnum.Moving
            };

            var resultInsert = operationsRepository.Add(operation);
            operation.Id = resultInsert;

            Assert.IsNotNull(resultInsert);

        }

        [TestMethod]
        public async Task TestOrdersAsync()
        {

            OrdersRepository ordersRepository = new OrdersRepository(databaseSingleton);
            OrderEntity order = new OrderEntity
            {
                Address = "Test",
                DeliveryTime = DateTime.Now,
                ClientId = 10
            };

            var resultInsert = ordersRepository.Add(order);
            order.Id = resultInsert;

            Assert.IsNotNull(resultInsert);

            order.Address = "Test2";
            ordersRepository.Update(order);
            var resultUpdate = databaseSingleton.DbContext.Orders.Find(resultInsert).Address;

            Assert.IsTrue(resultUpdate == order.Address);

            ordersRepository.Delete(resultInsert);
            var resultDelete = databaseSingleton.DbContext.Orders.Find(resultInsert).IsActive;
            Assert.IsFalse(resultDelete);
        }


        [TestMethod]
        public async Task TestProductsAsync()
        {

            ProductsRepository productsRepository = new ProductsRepository(databaseSingleton);
            ProductEntity product =  new ProductEntity
            {
                Description = "Test",
                Name = "Test",
                NumberPackagesOnStorage = 1,
                SpaceOccupied = 1,
                NumberPiecesInPackage = 1,
                Price = 1
            };

            var resultInsert = productsRepository.Add(product);
            product.Id = resultInsert;

            Assert.IsNotNull(resultInsert);

            product.Name = "Test2";
            productsRepository.Update(product);
            var resultUpdate = databaseSingleton.DbContext.Products.Find(resultInsert).Name;

            Assert.IsTrue(resultUpdate == product.Name);

            productsRepository.Delete(resultInsert);
            var resultDelete = databaseSingleton.DbContext.Products.Find(resultInsert).IsActive;
            Assert.IsFalse(resultDelete);
        }

        [TestMethod]
        public async Task TestAuthorizedService()
        {
            AuthorizationService authorizationService = new AuthorizationService(databaseSingleton);

            //var empl = authorizationService.Registrate(new EmployeeEntity
            //{
            //    Email = "Test3",
            //    Password = "Test",
            //    FirstName = "Test",
            //    SecondName = "Test",
            //    LastName = "Test",
            //    StorageId = 0,
            //    Phone = "Test",
            //    Role = 0,
            //    Position = "Test"
            //});

            //Assert.IsNotNull(empl);


            var logEmpl = authorizationService.Authorize("Test1", "Test");

            Assert.IsNotNull(logEmpl);

            authorizationService.DeleteAccount(1);
            var acc = databaseSingleton.DbContext.Employees.Find(1).IsActive;
            Assert.IsFalse (acc);

        }

    }
}