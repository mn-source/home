using Home.AirSensor.Client.Supla;
using Home.AirSensor.Probe.Service;
using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Home.AirSensor.Monitor.Service
{
    public class MonitorProcessService : IDisposable
    {
        private readonly Timer timer;
        private readonly SensorEntity sensorEntity;
        private readonly ProbeService probeService;

        public MonitorProcessService(SensorEntity sensorEntity,  ProbeService probeService)
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            this.sensorEntity = sensorEntity;
            this.probeService = probeService;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            probeService.RecieveSensorData(sensorEntity);
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
