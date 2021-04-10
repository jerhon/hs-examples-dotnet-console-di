using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Honlsoft.Examples.DependencyInjection
{
    public class TravelService : IHostedService
    {
        private readonly IHostApplicationLifetime _lifetime;
        private readonly Driver _driver;
        
        public TravelService(Driver driver, IHostApplicationLifetime lifetime)
        {
            _driver = driver;
            _lifetime = lifetime;
        }
        
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _driver.GoSomewhere();
            _lifetime.StopApplication();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}