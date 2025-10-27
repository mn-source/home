using Home.Air.Base.Sensor.Entity;
using Home.Base.Base.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Base.Sensor.Service;

public interface ISensorService<TKey> : IService<SensorEntity<TKey>, TKey>
{
    Task<List<SensorEntity<TKey>>> GetActiveSensorsAsync();
}