using System.Collections.Generic;

namespace Home.Air.Monitor.Client.Blebox.Model
{


    internal class BleboxAirSensorDataModel
    {
        public string Type { get; set; }
        public int QualityLevel { get; set; }
        public int Value { get; set; }
        public int Trend { get; set; }
        public int State { get; set; }
        public int ElapsedTimeS { get; set; }
    }
    internal class BleboxAirSensorModel
    {
        public int AirQualityLevel { get; set; }
        public List<BleboxAirSensorDataModel> Sensors { get; set; }
    }
    /*
{"air":{"airQualityLevel":1,
    "sensors":[{"type":"pm1","value":4,"trend":1,"state":1,"qualityLevel":-1,"elapsedTimeS":106},{ "type":"pm2.5","value":6,"trend":1,"state":1,"qualityLevel":1,"elapsedTimeS":106},{ "type":"pm10","value":6,"trend":1,"state":1,"qualityLevel":1,"elapsedTimeS":106}]}}
    */
    internal class BleboxAirModel
    {
        public BleboxAirSensorModel Air { get; set; }
    }
}
