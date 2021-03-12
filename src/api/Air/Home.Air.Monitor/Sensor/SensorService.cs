using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Repository;
using Home.Air.Base.Sensor.Service;
using Home.Service.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.AirSensor.Sensor.Service
{
    public class SensorService<TKey> : BaseService<SensorEntity<TKey>, TKey>, ISensorService<TKey>
    {
        private readonly ISensorRepository<TKey> sensorRepository;

        public SensorService(ISensorRepository<TKey> sensorRepository) : base(sensorRepository)
        {
            this.sensorRepository = sensorRepository;
        }


        public async Task<List<SensorEntity<TKey>>> GetActiveSensorsAsync()
        {
            return await sensorRepository.GetActiveSensorsAsync();
        }

    }
}
