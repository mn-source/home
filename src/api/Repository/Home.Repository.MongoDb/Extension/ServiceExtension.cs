using Home.Base.Key.Service;
using Home.Repository.MongoDb.Service;
using Home.Repository.MongoDb.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;

namespace Home.Repository.MongoDb.Extension
{
    public static class ServiceExtension
    {
        public static void RegisterMongoDbRepository(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //serviceCollection.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
            serviceCollection.AddSingleton<IKeyService<ObjectId>, MongoDbKeyService>();
        }
    }
}
