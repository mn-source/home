using Home.Air.Base.Sensor.Entity;
using Home.Base.Base.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Base.Sensor.Repository
{
    public interface ISensorRepository<TKey> : IRepository<SensorEntity<TKey>, TKey>
    {
        Task<List<SensorEntity<TKey>>> GetActiveSensorsAsync();
    }
}
