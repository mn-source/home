using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Service;
using Home.Base.Key.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Client.Api.Controllers.Air
{
    [Route("[controller]")]
    [ApiController]
    public class AirProbeController : ControllerBase
    {
        private readonly IProbeService<ObjectId> probeService;
        private readonly IKeyService<ObjectId> keyService;

        public AirProbeController(IProbeService<ObjectId> probeService, IKeyService<ObjectId> keyService)
        {
            this.probeService = probeService;
            this.keyService = keyService;
        }

        [HttpGet("probe")]
        public async Task<IEnumerable<ProbeEntity<ObjectId>>> SensorData(string sensorId)
        {
            var id = keyService.ParseKey(sensorId);
            return await probeService.GetSensorProbes(id);
        }
    }
}
