using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Service;
using System.Collections.Generic;

namespace Home.AirSensor.Sensor.Service
{
    public class SensorService<TKey> : ISensorService<TKey>
    {
        public List<SensorEntity<TKey>> GetActiveSensors()
        {
            return new List<SensorEntity<TKey>>
            {
                new SensorEntity<TKey>
                {
                    SensorName="Supla",
                    Type=SensorType.Temperature,
                    SensorApiAdress= "https://svr41.supla.org/direct/506/GMyzkhMDWZVBmYNJ/read"
                }

            };
        }

    }
}
