using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Honlsoft.Examples.DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host
                .CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IVehicle, MiniVan>();
                    services.AddSingleton<Driver>();
                    services.AddHostedService<TravelService>();
                });
        }
    }
}