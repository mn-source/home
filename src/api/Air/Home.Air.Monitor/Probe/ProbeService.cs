using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Repository;
using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Entity;
using Home.Air.Monitor.Client.Supla;
using Home.Service.Base;
using System;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Probe
{
    public class ProbeService<TKey> : BaseService<ProbeEntity<TKey>, TKey>, IProbeService<TKey>
    {
        private readonly IProbeRepository<TKey> probeRepository;

        public ProbeService(IProbeRepository<TKey> probeRepository) : base(probeRepository)
        {
            this.probeRepository = probeRepository;
        }

        public async Task RecieveSensorDataAsync(SensorEntity sensorEntity)
        {
            var client = GetClient(sensorEntity.Client);
            var latestData = await probeRepository.GetLatestDataAsync(sensorEntity.SensorId);
            var data = client.GetProbeData(sensorEntity);

            if (IsModelChanged(latestData, data))
            {
                var entityModel = GetEntityModel(data);
                await AddAsync(entityModel);
            }
        }

        private ProbeEntity<TKey> GetEntityModel(ProbeModel data)
        {
            throw new NotImplementedException();
        }

        private bool IsModelChanged(ProbeEntity<TKey> latestData, ProbeModel data)
        {
            throw new NotImplementedException();
        }

        private ISensorClientService GetClient(SensorClient client)
        {
            switch (client)
            {
                case SensorClient.Supla:
                    return new SuplaClientService();
                case SensorClient.Blebox:
                    break;
                default:
                    break;
            }

            throw new NotImplementedException();
        }
    }
}
