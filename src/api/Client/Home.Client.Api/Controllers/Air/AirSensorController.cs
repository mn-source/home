using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Service;
using Home.Base.Key.Service;
using Home.Client.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Home.Client.Api.Controllers.Air;

[Route("air/sensor")]
[ApiController]
public class AirSensorController(ISensorService<ObjectId> sensorService, IKeyService<ObjectId> keyService) : CRUDController<SensorEntity<ObjectId>, ObjectId>(sensorService, keyService)
{
    private readonly ISensorService<ObjectId> sensorService = sensorService;
    private readonly IKeyService<ObjectId> keyService = keyService;
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
