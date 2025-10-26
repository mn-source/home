using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Service;
using Home.Base.Key.Service;
using Home.Client.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Client.Api.Controllers.Air
{
    [Route("air/probe")]
    [ApiController]
    public class AirProbeController(IProbeService<ObjectId> probeService, IKeyService<ObjectId> keyService) : CRUDController<ProbeEntity<ObjectId>, ObjectId>(probeService, keyService)
    {
        private readonly IProbeService<ObjectId> probeService = probeService;
        private readonly IKeyService<ObjectId> keyService = keyService;

        [HttpGet("sensor/{sensorId}/all")]
        public async Task<IEnumerable<ProbeEntity<ObjectId>>> SensorData(string sensorId)
        {
            var id = keyService.ParseKey(sensorId);
            return await probeService.GetSensorProbes(id);
        }

        [HttpGet("sensor/{sensorId}/latest")]
        public async Task<ProbeEntity<ObjectId>> SensorDataLatests(string sensorId)
        {
            var id = keyService.ParseKey(sensorId);
            return await probeService.GetLatestDataAsync(id);
        }

        [HttpGet("sensor/{sensorId}/aggregate")]
        public async Task<IEnumerable<ProbeEntity<ObjectId>>> SensorDataAggregate(string sensorId, DateTime from, DateTime to, int aggregationMinutes)
        {
            var id = keyService.ParseKey(sensorId);
            return await probeService.GetSensorDataAggregate(id, from, to, aggregationMinutes);
        }
    }
}
