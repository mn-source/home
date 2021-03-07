using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Service;
using Home.Air.Monitor.Monitor;
using Home.Air.Monitor.Probe;
using Home.AirSensor.Sensor.Service;
using Home.MonitorHost;
using Microsoft.Extensions.DependencyInjection;

namespace Home.Client.MonitorHost
{
    public static class MonitorServiceHelper
    {
        public static void AddServices<TKey>(IServiceCollection services)
        {
            services.AddSingleton<ISensorService<TKey>, SensorService<TKey>>();
            services.AddSingleton<IProbeService<TKey>, ProbeService<TKey>>();            
            services.AddSingleton<MonitorService<TKey>>();
            services.AddHostedService<MonitorHostedService<TKey>>();
        }
    }
}
