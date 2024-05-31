using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Implementations.Repository;
using ArmSclad.Infrastructure.Implementations.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArmSclad.Infrastructure
{
    public static class DependencyInjection
    {
        //добавление зависимостей слоя инфраструктуры
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<MyDbContext>()
                .AddTransient<IClientsRepository, ClientsRepository>()
                .AddTransient<IEmployeeRepository, EmployeeRepository>()
                .AddTransient<IOperationsRepository, OperationsRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>()
                .AddTransient<IStoragesRepository, StoragesRepository>()
                .AddTransient<IOrdersRepository, OrdersRepository>()
                .AddTransient<IAuthorizationService, AuthorizationService>();

            return services;
        }
    }
}
