using Home.Air.Monitor.Monitor;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Home.Client.MonitorHost;

public class MonitorHostedService<TKey>(MonitorService<TKey> monitorService) : IHostedService
{
    private readonly MonitorService<TKey> monitorService = monitorService;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await monitorService.StartAsync();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await monitorService.StopAsync();
    }
}
