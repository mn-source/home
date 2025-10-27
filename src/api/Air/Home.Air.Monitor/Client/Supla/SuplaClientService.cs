using Home.Air.Base.Client;
using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Sensor.Entity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Home.Air.Monitor.Client.Supla;

public class SuplaClientService<TKey>(ILogger<SuplaClientService<TKey>> logger) : ISensorClientService<TKey>
{
    private readonly ILogger<SuplaClientService<TKey>> logger = logger;
    private static readonly HttpClient httpClient = new();

    public async Task<ProbeModel> GetProbeDataAsync(SensorEntity<TKey> sensorEntity)

    {
        try
        {
            var url = sensorEntity.SensorApiAddress;
            var responseString = await httpClient.GetStringAsync(url);

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
