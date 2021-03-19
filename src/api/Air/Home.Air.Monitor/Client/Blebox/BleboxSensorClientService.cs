using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Monitor.Client.Blebox.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;

namespace Home.Air.Monitor.Client.Blebox
{
    public class BleboxSensorClientService<TKey> : ISensorClientService<TKey>
    {
        private readonly ILogger<BleboxSensorClientService<TKey>> logger;

        public BleboxSensorClientService(ILogger<BleboxSensorClientService<TKey>> logger)
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

                switch (sensorEntity.Type)
                {
                    case SensorType.Temperature:
                        return GetTemperature(responseString);
                    case SensorType.AirQuality:
                        return GetAirData(responseString);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occured during recieving probe data.");
            }
            return null;
        }


        private static ProbeModel GetTemperature(string responseString)
        {
            var response = JsonConvert.DeserializeObject<BleboxTemperatureModel>(responseString);

            var value = response?.TempSensor?.Sensors?.FirstOrDefault();
            if (value != null)
            {
                var probe = new ProbeModel
                {
                    ProbeDate = DateTime.Now.AddSeconds(-value.ElapsedTimeS),
                    TemperatureCelcius = ((decimal)value.Value) / 100
                };
                return probe;
            }
            return null;
        }

        private static ProbeModel GetAirData(string responseString)
        {
            var response = JsonConvert.DeserializeObject<BleboxAirModel>(responseString);
            var airData = response?.Air?.Sensors;
            var info = airData.FirstOrDefault();
            if (info != null)
            {
                var probe = new ProbeModel
                {
                    ProbeDate = DateTime.Now.AddSeconds(-info.ElapsedTimeS)
                };

                var pm1 = airData.FirstOrDefault(b => b.Type == "pm1");
                if (pm1 != null)
                {
                    probe.Pm1 = pm1.Value;
                }

                var pm10 = airData.FirstOrDefault(b => b.Type == "pm10");
                if (pm10 != null)
                {
                    probe.Pm10 = pm10.Value;
                }


                var pm2_5 = airData.FirstOrDefault(b => b.Type == "pm2.5");
                if (pm2_5 != null)
                {
                    probe.Pm2_5 = pm2_5.Value;
                }


                return probe;
            }
            return null;
        }
    }
}
