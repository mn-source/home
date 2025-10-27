using System.Collections.Generic;

namespace Home.Air.Monitor.Client.Blebox.Model;

internal class BleboxTemperatureSensorDataModel
{
    public string Type { get; set; }
    public int Id { get; set; }
    public int Value { get; set; }
    public int Trend { get; set; }
    public int State { get; set; }
    public int ElapsedTimeS { get; set; }
}
internal class BleboxTemperatureSensorModel
{
    public List<BleboxTemperatureSensorDataModel> Sensors { get; set; }
}

internal class BleboxTemperatureModel
{
    public BleboxTemperatureSensorModel TempSensor { get; set; }
}
