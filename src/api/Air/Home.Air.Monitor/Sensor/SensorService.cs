using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Repository;
using Home.Air.Base.Sensor.Service;
using Home.Service.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Sensor;

public class SensorService<TKey>(ISensorRepository<TKey> sensorRepository) : BaseService<SensorEntity<TKey>, TKey>(sensorRepository), ISensorService<TKey>
{
    private readonly ISensorRepository<TKey> sensorRepository = sensorRepository;

    public async Task<List<SensorEntity<TKey>>> GetActiveSensorsAsync()
    {
        return await sensorRepository.GetActiveSensorsAsync();
    }

}
