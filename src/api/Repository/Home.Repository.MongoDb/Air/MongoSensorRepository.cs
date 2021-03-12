using Home.Air.Base.Sensor.Entity;
using Home.Air.Base.Sensor.Repository;
using Home.Repository.MongoDb.Base;
using Home.Repository.MongoDb.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Repository.MongoDb.Air
{
    public class MongoSensorRepository : MongoDbRepository<SensorEntity<ObjectId>>, ISensorRepository<ObjectId>
    {
        public MongoSensorRepository(IOptions<MongoDbSettings> options) : base(options)
        {
        }

        public async Task<List<SensorEntity<ObjectId>>> GetActiveSensorsAsync()
        {
            var item = Collection.Find(b => b.IsActive);
            return await item.ToListAsync();
        }
    }
}
