using Home.Air.Base.Probe.Entity;
using Home.Base.Base.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Base.Probe.Repository
{
    public interface IProbeRepository<TKey> : IRepository<ProbeEntity<TKey>, TKey>
    {
        Task<ProbeEntity<TKey>> GetLatestDataAsync(TKey sensorId);
        Task<IEnumerable<ProbeEntity<TKey>>> GetSensorProbesAsync(TKey sensorId);
        Task<IEnumerable<ProbeEntity<TKey>>> GetSensorDataAggregate(TKey sensorId, DateTime from, DateTime to, int aggregationMinutes);
    }
}
