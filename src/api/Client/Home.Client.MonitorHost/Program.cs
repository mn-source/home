using Home.Client.MonitorHost;
using Home.Repository.MongoDb.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson;
using System.IO;
using System.Threading.Tasks;

namespace Home.MonitorHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                    configHost.AddJsonFile("appsettings.json", optional: false);
                    configHost.AddEnvironmentVariables(prefix: "PREFIX_");
                    configHost.AddCommandLine(args);
                }).ConfigureServices((host, services) =>
                {
                    MonitorServiceHelper.AddServices<ObjectId>(services);
                    services.RegisterMongoDbRepository(host.Configuration);
                });

    }
}
