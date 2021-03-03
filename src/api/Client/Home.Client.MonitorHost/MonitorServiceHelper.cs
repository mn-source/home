using Home.Air.Monitor.Monitor;
using Home.MonitorHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Client.MonitorHost
{
    public static class MonitorServiceHelper
    {
        public static void AddServices<TKey>(IServiceCollection services)
        {
            services.AddSingleton<MonitorService<TKey>>();
            services.AddHostedService<MonitorHostedService<TKey>>();
        }
    }
}
