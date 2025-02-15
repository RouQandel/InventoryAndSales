using Microsoft.Extensions.DependencyInjection;
using Presantation;
using Microsoft.EntityFrameworkCore;
using AccessDataLayer; // Replace with the namespace of your DbContext

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build the service provider
            using var serviceProvider = services.BuildServiceProvider();

            // Run the application
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register your DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("InventorySales"));

            // Register your forms and other services
            services.AddTransient<Form1>();
            // services.AddTransient<OtherForm>(); // Add other forms if needed
        }
    }
}