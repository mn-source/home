using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Service;
using Home.Air.Monitor.Probe;
using System;
using System.Collections.Generic;

namespace Home.Air.Monitor.Monitor
{
    public class MonitorService<TKey> : IDisposable
    {
        private List<MonitorProcessService<TKey>> timers;
        private bool disposedValue;
        private readonly ISensorService<TKey> sensorService;
        private readonly IProbeService<TKey> probeService;


        public MonitorService(
            ISensorService<TKey> sensorService,
          IProbeService<TKey> probeService)
        {
            this.sensorService = sensorService;
            this.probeService = probeService;
        }
        public void Start()
        {
            timers = new List<MonitorProcessService<TKey>>();
            var sensors = sensorService.GetActiveSensors();

            foreach (var sensor in sensors)
            {
                var timer = new MonitorProcessService<TKey>(sensor, probeService);
                timer.Start();
                timers.Add(timer);
            }
        }

        public void Stop()
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
