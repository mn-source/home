// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019

using System.Text.Json.Serialization;

namespace Home.Base.Base.Entity;

public abstract class BaseEntity<TKey>
{
    [JsonIgnore]
    public TKey Id { get; set; }
    public string IdString { get; set; }
}
