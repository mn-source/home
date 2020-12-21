using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Home.AirSensor.Probe.Entity
{
    public class Enviroment
    {
        public DateTime ProbeDate { get; set; }

        public SensorEntity Sensor { get; set; }

        public decimal TemperatureCelcius { get; set; }

        public decimal? HumidityPercent { get; set; }
    }
}
