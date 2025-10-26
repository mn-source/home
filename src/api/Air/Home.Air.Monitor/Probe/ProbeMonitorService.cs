using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Monitor.Client.Blebox;
using Home.Air.Monitor.Client.Supla;
using System;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Probe
{
    public class ProbeMonitorService<TKey> : IProbeMonitorService<TKey>
    {
        private readonly IProbeService<TKey> probeService;
        private readonly SuplaClientService<TKey> suplaClientService;
        private readonly BleboxSensorClientService<TKey> bleboxSensorClientService;

        public ProbeMonitorService(
            IProbeService<TKey> probeService,
            SuplaClientService<TKey> suplaClientService,
            BleboxSensorClientService<TKey> bleboxSensorClientService)  
        {
            this.probeService = probeService;
            this.suplaClientService = suplaClientService;
            this.bleboxSensorClientService = bleboxSensorClientService;
        }

        public async Task RecieveSensorDataAsync(SensorEntity<TKey> sensorEntity)
        {
            var client = GetClient(sensorEntity.Client);
            var latestData = await probeService.GetLatestDataAsync(sensorEntity.Id);
            var data = client.GetProbeData(sensorEntity);

            if (data == null)
            {
                return;
            }


            if (IsModelChanged(latestData, data))
            {
                var entityModel = GetEntityModel(data, sensorEntity);
                await probeService.AddAsync(entityModel);
            }
        }

        private static ProbeEntity<TKey> GetEntityModel(ProbeModel data, SensorEntity<TKey> sensorEntity)
        {
            var probe = new ProbeEntity<TKey>
            {
                SensorId = sensorEntity.Id,
                ProbeDate = DateTime.Now,
                TemperatureCelcius = data.TemperatureCelcius,
                Pm1 = data.Pm1,
                Pm2_5 = data.Pm2_5,
                Pm10 = data.Pm10,
                HumidityPercent = data.HumidityPercent
            };
            return probe;
        }

        private static bool IsModelChanged(ProbeEntity<TKey> latestData, ProbeModel data)
        {
            if (data == null)
            {
                return false;
            }

            if (latestData == null)
            {
                return true;
            }

            if (IsValueChanched(latestData.CAQI, data.CAQI))
            {
                return true;
            }

            if (IsValueChanched(latestData.HumidityPercent, data.HumidityPercent))
            {
                return true;
            }

            if (IsValueChanched(latestData.Pm1, data.Pm1))
            {
                return true;
            }

            if (IsValueChanched(latestData.Pm2_5, data.Pm2_5))
            {
                return true;
            }

            if (IsValueChanched(latestData.Pm10, data.Pm10))
            {
                return true;
            }

            if (IsValueChanched(latestData.TemperatureCelcius, data.TemperatureCelcius))
            {
                return true;
            }
            return false;
        }


        private static bool IsValueChanched<T>(T? value1, T? value2) where T : struct
        {
            if (value1 == null && value2 == null)
            {
                return false;
            }

            if (value1 == null || value2 == null)
            {
                return true;
            }

            if (value1.Value.Equals(value2.Value))
            {
                return false;
            }
            return true;

        }

        private ISensorClientService<TKey> GetClient(SensorClient client)
        {
            switch (client)
            {
                case SensorClient.Supla:
                    return suplaClientService;
                case SensorClient.Blebox:
                    return bleboxSensorClientService;
                default:
                    break;
            }

            throw new NotImplementedException();
        }
    }
}
