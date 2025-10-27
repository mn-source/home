namespace Home.Air.Monitor.Client.Supla;

internal class SuplaResponseModel
{
    public bool Connected { get; set; }
    public decimal Humidity { get; set; }
    public decimal Temperature { get; set; }
}
