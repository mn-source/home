using Home.AirSensor.Probe.Service;
using Home.AirSensor.Sensor.Service;
using System;
using System.Collections.Generic;

namespace Home.AirSensor.Monitor.Service
{
    public class MonitorService : IDisposable
    { 
        private List<MonitorProcessService> timers;
        private bool disposedValue;
        private readonly SensorService sensorService;
        private readonly ProbeService probeService;


        public MonitorService()
        {
            sensorService = new SensorService();
            probeService = new ProbeService();
        }
        public void Start()
        {
            timers = new List<MonitorProcessService>();
            var sensors = sensorService.GetActiveSensors();


            foreach (var sensor in sensors)
            {
                var timer = new MonitorProcessService(sensor, probeService);  
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
