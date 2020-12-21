using Home.AirSensor.Probe.Entity;
using Home.AirSensor.Sensor.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AirSensorController : ControllerBase
    {
        [HttpGet("Quality")]
        public IEnumerable<Quality> GetQualityAll()
        {
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new Quality
            {
                ProbeDate = DateTime.Now.AddHours(-index),
                Sensor = new SensorEntity
                {
                    SensorId = rng.Next(1, 3),
                    SensorName = "Quality Sensor"
                },
                Pm1 = rng.Next(0, 55),
                Pm2_5 = rng.Next(0, 55),
                Pm10 = rng.Next(0, 55),
                CAQI = rng.Next(0, 200)
            })
            .ToArray();
        }

        [HttpGet("Enviroment")]
        public IEnumerable<Enviroment> GetEnviromentAll()
        {
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new Enviroment
            {
                ProbeDate = DateTime.Now.AddHours(-index),
                Sensor = new SensorEntity
                {
                    SensorId = rng.Next(1, 3),
                    SensorName = "Enviroment Sensor"
                },
                TemperatureCelcius = rng.Next(-20, 45),
                HumidityPercent = rng.Next(20, 60)
            })
            .ToArray();

        }
    }
}
