using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Repository;
using Home.Air.Base.Probe.Service;
using Home.Service.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Probe
{
    public class ProbeService<TKey>(
        IProbeRepository<TKey> probeRepository) : BaseService<ProbeEntity<TKey>, TKey>(probeRepository), IProbeService<TKey>
    {
        private readonly IProbeRepository<TKey> probeRepository = probeRepository;

        public async Task<ProbeEntity<TKey>> GetLatestDataAsync(TKey sensorId)
        {
            return await probeRepository.GetLatestDataAsync(sensorId);
        }

        public Task<IEnumerable<ProbeEntity<TKey>>> GetSensorDataAggregate(TKey sensorId, DateTime from, DateTime to, int aggregationMinutes)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProbeEntity<TKey>>> GetSensorProbes(TKey sensorId)
        {
            return await probeRepository.GetSensorProbesAsync(sensorId);
        }

    }
}
