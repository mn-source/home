using Home.Air.Base.Probe.Entity;
using Home.Base.Base.Repository;
using System.Threading.Tasks;

namespace Home.Air.Base.Probe.Repository
{
    public interface IProbeRepository<TKey> : IRepository<ProbeEntity<TKey>, TKey>
    {
        Task<ProbeEntity<TKey>> GetLatestDataAsync(TKey sensorId);
    }
}
