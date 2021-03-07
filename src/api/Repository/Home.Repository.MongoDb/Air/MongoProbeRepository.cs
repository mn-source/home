using Home.Air.Base.Probe.Entity;
using Home.Air.Base.Probe.Repository;
using Home.Repository.MongoDb.Base;
using Home.Repository.MongoDb.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace Home.Repository.MongoDb.Air
{
    public class MongoProbeRepository : MongoDbRepository<ProbeEntity<ObjectId>>, IProbeRepository<ObjectId>
    {
        public MongoProbeRepository(IOptions<MongoDbSettings> options) : base(options)
        {
        }

        public Task<ProbeEntity<ObjectId>> GetLatestDataAsync(int sensorId)
        {
            throw new NotImplementedException();
        }
    }
}
