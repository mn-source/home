using Home.AirSensor.Probe.Entity;
using Home.AirSensor.Sensor.Entity;

namespace Home.AirSensor.Client
{
    public interface IClientService
    {
        ProbeEntity GetProbeData(SensorEntity sensorEntity);
    }
}