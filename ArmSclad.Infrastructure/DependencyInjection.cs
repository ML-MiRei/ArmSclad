using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Domain.Interfaces.Services.AuthorizationService;
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
            services.AddSingleton<DatabaseSingleton>()
                .AddTransient<IClientsRepository, ClientsRepository>()
                .AddTransient<IEmployeeRepository, EmployeeRepository>()
                .AddTransient<IOperationsRepository, OperationsRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>()
                .AddTransient<IStoragesRepository, StoragesRepository>()
                .AddTransient<IAuthorizationService, AuthorizationService>();

            return services;
        }
    }
}
