using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Home.Base.Base.Service;
using System.Threading.Tasks;

namespace Home.Air.Base.Probe.Service
{
    public interface IProbeService<TKey> : IService<ProbeEntity<TKey>, TKey>
    {
        Task RecieveSensorDataAsync(SensorEntity<TKey> sensorEntity);
    }
}