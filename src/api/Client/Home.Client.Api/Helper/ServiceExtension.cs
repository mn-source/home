using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Service;
using Home.Air.Monitor.Probe;
using Home.Air.Monitor.Sensor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Home.Client.Api.Helper;

public static class ServiceExtension
{
    public static void RegisterApplication<TKey>(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<ISensorService<TKey>, SensorService<TKey>>();
        services.AddSingleton<IProbeService<TKey>, ProbeService<TKey>>();

    }
}
