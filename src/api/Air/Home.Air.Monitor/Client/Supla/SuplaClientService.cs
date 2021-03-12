using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Home.Air.Monitor.Client.Supla
{
    public class SuplaClientService<TKey> : ISensorClientService<TKey>
    {
        private readonly ILogger<SuplaClientService<TKey>> logger;

        public SuplaClientService(ILogger<SuplaClientService<TKey>> logger)
        {
            this.logger = logger;
        }
        public ProbeModel GetProbeData(SensorEntity<TKey> sensorEntity)
        {
            try
            {
                var url = sensorEntity.SensorApiAdress;
                var client = new WebClient();
                var responseString = client.DownloadString(url);

                var response = JsonConvert.DeserializeObject<SuplaResponseModel>(responseString);
                if (response.Connected)
                {
                    var probe = new ProbeModel
                    {
                        ProbeDate = DateTime.Now,
                        TemperatureCelcius = response.Temperature,
                        HumidityPercent = response.Humidity
                    };
                    return probe;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during load data.");
            }
            return null;
        }
    }
}
