using Home.AirSensor.Probe.Entity;
using Home.AirSensor.Sensor.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Home.AirSensor.Client.Supla
{
    public class SuplaClientService : IClientService
    {
        public ProbeEntity GetProbeData(SensorEntity sensorEntity)
        {
            var url = sensorEntity.SensorApiAdress;
            var client = new WebClient();
            var responseString = client.DownloadString(url);
            var probe = new ProbeEntity
            {
                ProbeDate = DateTime.Now
            };
            return probe;
        }
    }
}
