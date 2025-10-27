using Home.Base.Base.Entity;
using System;

namespace Home.Air.Base.Probe.Entity;

public class ProbeEntity<TKey> : BaseEntity<TKey>
{
    public DateTime ProbeDate { get; set; }

    public TKey SensorId { get; set; }

    public decimal? TemperatureCelcius { get; set; }

    public decimal? HumidityPercent { get; set; }

    public int? Pm1 { get; set; }

    public int? Pm2_5 { get; set; }

    public int? Pm10 { get; set; }

    public int? CAQI { get; set; }
}
