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

        [HttpGet("Probe")]
        public IEnumerable<ProbeEntity> GetEnviromentAll()
        {
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new ProbeEntity
            {
                ProbeDate = DateTime.Now.AddHours(-index),
                Sensor = new SensorEntity
                {
                    SensorId = rng.Next(1, 3),
                    SensorName = "Enviroment Sensor"
                },
                TemperatureCelcius = rng.Next(-20, 45),
                HumidityPercent = rng.Next(20, 60),
                Pm1 = rng.Next(0, 55),
                Pm2_5 = rng.Next(0, 55),
                Pm10 = rng.Next(0, 55),
                CAQI = rng.Next(0, 200)
            })
            .ToArray();

        }
    }
}
