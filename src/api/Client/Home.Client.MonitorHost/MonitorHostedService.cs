using Home.Air.Monitor.Monitor;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Home.MonitorHost
{
    public class MonitorHostedService<TKey> : IHostedService
    {
        private readonly MonitorService<TKey> monitorService;

        public MonitorHostedService(MonitorService<TKey> monitorService)
        {
            this.monitorService = monitorService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await monitorService.StartAsync();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await monitorService.StopAsync();
        }
    }
}
