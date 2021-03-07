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
        private readonly IProbeService<TKey> probeService;

        public MonitorProcessService(SensorEntity<TKey> sensorEntity, IProbeService<TKey> probeService)
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            this.sensorEntity = sensorEntity;
            this.probeService = probeService;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            probeService.RecieveSensorDataAsync(sensorEntity).Wait();
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
