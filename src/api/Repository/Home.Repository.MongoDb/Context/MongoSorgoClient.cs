﻿// Copyright (C) Sorgo - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using Home.Repository.MongoDb.Settings;
using MongoDB.Driver;

namespace Home.Repository.MongoDb.Context;

internal static class MongoSorgoClient
{
    public static MongoClient GetClient(MongoDbSettings settings)
    {
        return new MongoClient(settings.ConnectionsString);
    }
}
