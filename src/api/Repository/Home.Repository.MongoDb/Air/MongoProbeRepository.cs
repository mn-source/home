using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Repository;
using Home.Repository.MongoDb.Base;
using Home.Repository.MongoDb.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Client.Client.Repository.MongoDb.Air
{
    public class MongoProbeRepository(IOptions<MongoDbSettings> options) : MongoDbRepository<ProbeEntity<ObjectId>>(options), IProbeRepository<ObjectId>
    {
        public async Task<ProbeEntity<ObjectId>> GetLatestDataAsync(ObjectId sensorId)
        {
            var sort = Builders<ProbeEntity<ObjectId>>.Sort.Descending(s => s.ProbeDate);
            var item = Collection.Find(b => b.SensorId== sensorId).Sort(sort);
            return await item.FirstOrDefaultAsync();
        }

        public Task<IEnumerable<ProbeEntity<ObjectId>>> GetSensorDataAggregate(ObjectId sensorId, DateTime from, DateTime to, int aggregationMinutes)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProbeEntity<ObjectId>>> GetSensorProbesAsync(ObjectId sensorId)
        {
            var item = Collection.Find(b => b.SensorId == sensorId);
            return await item.ToListAsync();
        }
    }
}
