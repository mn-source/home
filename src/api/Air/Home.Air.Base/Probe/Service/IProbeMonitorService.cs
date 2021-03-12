using Home.Air.Base.Sensor.Entity;
using System.Threading.Tasks;

namespace Home.Air.Base.Probe.Service
{
    public interface IProbeMonitorService<TKey>
    {
        Task RecieveSensorDataAsync(SensorEntity<TKey> sensorEntity);
    }
}