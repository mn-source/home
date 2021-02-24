using Home.AirSensor.Monitor.Service;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home.MonitorHost
{
    public class MonitorHostedService : IHostedService
    {
        private readonly MonitorService monitorService;

        public MonitorHostedService(MonitorService monitorService)
        {
            this.monitorService = monitorService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            monitorService.Start();
            //throw new NotImplementedException();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            monitorService.Stop();
        }
    }
}
