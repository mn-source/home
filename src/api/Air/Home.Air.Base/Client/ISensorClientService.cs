using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using System.Threading.Tasks;

namespace Home.Air.Base.Client
{
    public interface ISensorClientService<TKey>
    {
        Task<ProbeModel> GetProbeDataAsync(SensorEntity<TKey> sensorEntity);
    }
}