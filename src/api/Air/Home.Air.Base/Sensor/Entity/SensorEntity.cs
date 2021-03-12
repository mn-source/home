using Home.Base.Base.Entity;

namespace Home.Air.Base.Sensor.Entity
{
    public class SensorEntity<TKey> : BaseEntity<TKey>
    {
        public string SensorName { get; set; }
        public SensorType Type { get; set; }
        public SensorClient Client { get; set; }
        public string SensorApiAdress { get; set; }
        public bool IsActive { get; set; }
    }
}
