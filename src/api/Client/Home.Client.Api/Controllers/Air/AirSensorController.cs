
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Service;
using Home.AirSensor.Sensor.Service;
using Home.Base.Key.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
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
        private readonly ISensorService<ObjectId> sensorService;
        private readonly IKeyService<ObjectId> keyService;

        public AirSensorController(ISensorService<ObjectId> sensorService, IKeyService<ObjectId> keyService)
        {
            this.sensorService = sensorService;
            this.keyService = keyService;
        }
        [HttpGet("sensors")]
        public async Task<IEnumerable<SensorEntity<ObjectId>>> Sensors()
        {
            return await sensorService.GetAllAsync();
        }
    }
}
