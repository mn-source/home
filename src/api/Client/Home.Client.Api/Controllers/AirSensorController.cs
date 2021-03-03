
using Home.Air.Base.Probe.Entity;
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
        public IEnumerable<ProbeEntity<int>> GetEnviromentAll()
        {
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new ProbeEntity<int>
            {
                ProbeDate = DateTime.Now.AddHours(-index),
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
