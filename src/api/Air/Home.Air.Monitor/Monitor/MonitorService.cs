using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Service;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Monitor
{
    public class MonitorService<TKey> : IDisposable
    {
        private List<MonitorProcessService<TKey>> timers;
        private bool disposedValue;
        private readonly ISensorService<TKey> sensorService;
        private readonly IProbeMonitorService<TKey> probeMonitorService;
        private readonly ILogger<MonitorService<TKey>> logger;

        public MonitorService(
            ISensorService<TKey> sensorService,
            IProbeMonitorService<TKey> probeMonitorService,
            ILogger<MonitorService<TKey>> logger)
        {
            this.sensorService = sensorService;
            this.probeMonitorService = probeMonitorService;
            this.logger = logger;
        }
        public async Task StartAsync()
        {
            logger.LogDebug("StartAsync");
            timers = new List<MonitorProcessService<TKey>>();
            var sensors = await sensorService.GetActiveSensorsAsync();

            foreach (var sensor in sensors)
            {
                var timer = new MonitorProcessService<TKey>(sensor, probeMonitorService);
                timer.Start();
                timers.Add(timer);
            }
        }

        public async Task StopAsync()
        {
            logger.LogDebug("StopAsync");
            await Task.Run(StopTimers);
        }

        private void StopTimers()
        {
            foreach (var sensor in timers)
            {
                sensor.Stop();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    foreach (var timer in timers)
                    {
                        timer.Dispose();
                    }
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}
