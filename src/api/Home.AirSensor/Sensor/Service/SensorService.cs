using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.AirSensor.Sensor.Service
{
    public class SensorService
    {
        internal List<SensorEntity> GetActiveSensors()
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
