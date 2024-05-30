using ArmSclad.Core.Entities;
using ArmSclad.Domain;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Infrastructure;
using ArmSclad.UI.Main;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.OperationsViews;
using ArmSclad.UI.Main.Modules.OperationsWithProductsViews;
using ArmSclad.UI.Main.Modules.OrdersView;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews;
using ArmSclad.UI.Modules.Login.View;
using ArmSclad.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArmSclad.UI
{
    internal static class Program
    {

        public static EmployeeEntity CurrentUser { get; set; }

        [STAThread]
        static void Main()
        {

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {

                services.AddDomain();
                services.AddInfrastructure();

                services.AddTransient<IRequestService, RequestService>();

                services.AddSingleton<LoginForm>();
                services.AddSingleton<SigninForm>();
                services.AddSingleton<SignupForm>();

                services.AddSingleton<OperationsEmployeeForm>();
                services.AddSingleton<ProductsForm>();
                services.AddSingleton<OrdersForm>();
                services.AddSingleton<ObserveOperationsForm>();
                services.AddSingleton<StoragesForm>();
                services.AddSingleton<OperationsWithProductsForm>();
                services.AddSingleton<ClientsForm>();
                services.AddSingleton<MainForm>();

            }).Build();
            IServiceProvider ServiceProvider = host.Services;

            if (string.IsNullOrEmpty(Settings.Default.Email))
            {
                if ((ServiceProvider.GetRequiredService<LoginForm>()).ShowDialog() == DialogResult.Cancel)
                    return;
            }
            else
            {
                var service = ServiceProvider.GetRequiredService<IAuthorizationService>();
                CurrentUser = service.Authorize(Settings.Default.Email, Settings.Default.Password);
            }
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());

        }
    }
}