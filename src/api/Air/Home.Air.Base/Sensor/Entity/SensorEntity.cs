namespace Home.Air.Base.Sensor.Entity
{
    public class SensorEntity
    {
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public SensorType Type { get; set; }
        public SensorClient Client { get; set; }
        public string SensorApiAdress { get; set; }
    }
}
