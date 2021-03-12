using Home.Air.Base.Probe.Entity;
using Home.Base.Base.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Base.Probe.Service
{
    public interface IProbeService<TKey> : IService<ProbeEntity<TKey>, TKey>
    {
        Task<IEnumerable<ProbeEntity<TKey>>> GetSensorProbes(TKey sensorId);
        Task<ProbeEntity<TKey>> GetLatestDataAsync(TKey sensorId);
    }
}