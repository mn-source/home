using Home.Base.Key.Service;
using MongoDB.Bson;

namespace Home.Repository.MongoDb.Service
{
    public class MongoDbKeyService : IKeyService<ObjectId>
    {
        public string GetKeyString(ObjectId key)
        {
            return key.ToString();
        }

        public ObjectId ParseKey(string keyString)
        {
            if(string.IsNullOrEmpty(keyString))
            {
                return new ObjectId();
            }
            return new ObjectId(keyString);
        }
    }
}
