using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Service;
using Home.Base.Key.Service;
using Home.Client.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Client.Api.Controllers.Air
{
    [Route("air/probe")]
    [ApiController]
    public class AirProbeController : CRUDController<ProbeEntity<ObjectId>, ObjectId>
    {
        private readonly IProbeService<ObjectId> probeService;
        private readonly IKeyService<ObjectId> keyService;

        public AirProbeController(IProbeService<ObjectId> probeService, IKeyService<ObjectId> keyService)
            : base(probeService, keyService)
        {
            this.probeService = probeService;
            this.keyService = keyService;
        }

        [HttpGet("sensor/{sensorId}/all")]
        public async Task<IEnumerable<ProbeEntity<ObjectId>>> SensorData(string sensorId)
        {
            var id = keyService.ParseKey(sensorId);
            var probes = await probeService.GetSensorProbes(id);
            return probes.Select(b =>
            {
                b.IdString = keyService.GetKeyString(b.Id);
                return b;
            }).ToList();
        }
        [HttpGet("sensor/{sensorId}/latest")]
        public async Task<ProbeEntity<ObjectId>> SensorDataLatests(string sensorId)
        {
            var id = keyService.ParseKey(sensorId);
            var probe = await probeService.GetLatestDataAsync(id);
            probe.IdString = keyService.GetKeyString(probe.Id);
            return probe;
        }
    }
}
