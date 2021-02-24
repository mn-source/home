using Home.AirSensor.Client;
using Home.AirSensor.Client.Supla;
using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.AirSensor.Probe.Service
{
    public class ProbeService
    {
        public void RecieveSensorData(SensorEntity sensorEntity)
        {
            var client = GetClient(sensorEntity.Client);
            var data = client.GetProbeData(sensorEntity);
        }

        private IClientService GetClient(SensorClient client)
        {
            switch(client)
            {
                case SensorClient.Supla:
                    return new SuplaClientService();
            }
            
            throw new NotImplementedException();
        }
    }
}
