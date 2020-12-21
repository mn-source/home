using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Home.AirSensor.Probe.Entity
{
    public class Quality
    {
        public DateTime ProbeDate { get; set; }

        public SensorEntity Sensor { get; set; }

        public int Pm1 { get; set; }

        public int Pm2_5 { get; set; }

        public int Pm10 { get; set; }

        public int CAQI { get; set; }

    }
}
