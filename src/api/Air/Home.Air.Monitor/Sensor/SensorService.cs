using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Service;
using System.Collections.Generic;

namespace Home.AirSensor.Sensor.Service
{
    public class SensorService : ISensorService
    {
        public List<SensorEntity> GetActiveSensors()
        {
            return new List<SensorEntity>
            {
                new SensorEntity
                {
                    SensorId=0,
                    SensorName="Supla",
                    Type=SensorType.Temperature,
                    SensorApiAdress= "https://svr41.supla.org/direct/506/GMyzkhMDWZVBmYNJ/read"
                }

            };
        }

    }
}
