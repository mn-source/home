
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Service;
using Home.AirSensor.Sensor.Service;
using Home.Base.Key.Service;
using Home.Client.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Api.Controllers
{
    [Route("air/sensor")]
    [ApiController]
    public class AirSensorController : CRUDController<SensorEntity<ObjectId>, ObjectId>
    {
        private readonly ISensorService<ObjectId> sensorService;
        private readonly IKeyService<ObjectId> keyService;

        public AirSensorController(ISensorService<ObjectId> sensorService, IKeyService<ObjectId> keyService) : base(sensorService, keyService)
        {
            this.sensorService = sensorService;
            this.keyService = keyService;
        }
        //[HttpGet("all")]
        //public async Task<IEnumerable<SensorEntity<ObjectId>>> GetAllSensros()
        //{
        //    var sensors = await sensorService.GetAllAsync();
        //    return sensors.Select(b =>
        //    {
        //        b.IdString = keyService.GetKeyString(b.Id);
        //        return b;
        //    }).ToList();
        //}
    }
}
