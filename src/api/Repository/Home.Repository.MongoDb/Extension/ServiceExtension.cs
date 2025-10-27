using Home.Air.Base.Probe.Repository;
using Home.Air.Base.Sensor.Repository;
using Home.Base.Key.Service;
using Home.Repository.MongoDb.Air;
using Home.Repository.MongoDb.Service;
using Home.Repository.MongoDb.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;

namespace Home.Repository.MongoDb.Extension;

public static class ServiceExtension
{
    public static void RegisterMongoDbRepository(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
        serviceCollection.AddSingleton<IKeyService<ObjectId>, MongoDbKeyService>();
        serviceCollection.AddSingleton<IProbeRepository<ObjectId>, MongoProbeRepository>();
        serviceCollection.AddSingleton<ISensorRepository<ObjectId>, MongoSensorRepository>();
    }
}
