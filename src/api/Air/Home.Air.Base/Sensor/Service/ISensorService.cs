using Home.Air.Base.Sensor.Entity;
using System.Collections.Generic;

namespace Home.Air.Base.Sensor.Service
{
    public interface ISensorService
    {
        List<SensorEntity> GetActiveSensors();
    }
}