using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Entity;
using System;
using System.Timers;

namespace Home.Air.Monitor.Monitor
{
    public class MonitorProcessService<TKey> : IDisposable
    {
        private readonly Timer timer;
        private readonly SensorEntity<TKey> sensorEntity;
        private readonly IProbeMonitorService<TKey> probeMonitorService;

        public MonitorProcessService(SensorEntity<TKey> sensorEntity, IProbeMonitorService<TKey>  probeMonitorService)
        {
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Elapsed += Timer_Elapsed;
            this.sensorEntity = sensorEntity;
            this.probeMonitorService = probeMonitorService;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            probeMonitorService.RecieveSensorDataAsync(sensorEntity).Wait();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }



        #region dispose
        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    timer.Dispose();
                }
                disposedValue = true;
            }
        }

        ~MonitorProcessService()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion 
    }
}
