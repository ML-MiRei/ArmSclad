using ArmSclad.Domain;
using ArmSclad.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.Design;
using System.DirectoryServices.ActiveDirectory;

namespace ArmSclad.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {

                services.AddDomain();
                services.AddInfrastructure();

            }).Build();
            IServiceProvider ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Form1>());

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}