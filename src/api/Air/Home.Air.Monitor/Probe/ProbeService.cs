using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Repository;
using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Monitor.Client.Blebox;
using Home.Air.Monitor.Client.Supla;
using Home.Service.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Probe
{
    public class ProbeService<TKey> : BaseService<ProbeEntity<TKey>, TKey>, IProbeService<TKey>
    {
        private readonly IProbeRepository<TKey> probeRepository;

        public ProbeService(
            IProbeRepository<TKey> probeRepository) : base(probeRepository)
        {
            this.probeRepository = probeRepository;
        }

        public async Task<ProbeEntity<TKey>> GetLatestDataAsync(TKey sensorId)
        {
            return await probeRepository.GetLatestDataAsync(sensorId);
        }

        public async Task<IEnumerable<ProbeEntity<TKey>>> GetSensorProbes(TKey sensorId)
        {
            return await probeRepository.GetSensorProbesAsync(sensorId);
        }
         
    }
}
