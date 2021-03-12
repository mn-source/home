using Home.Air.Base.Probe.Service;
using Home.Air.Base.Sensor.Service;
using Home.Air.Monitor.Probe;
using Home.AirSensor.Sensor.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Client.Api.Helper
{
    public static class ServiceExtension
    {
        public static void RegisterApplication<TKey>(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISensorService<TKey>, SensorService<TKey>>();
            services.AddSingleton<IProbeService<TKey>, ProbeService<TKey>>();

        }
    }
}
