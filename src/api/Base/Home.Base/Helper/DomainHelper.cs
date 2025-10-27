﻿// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using System;

namespace Home.Base.Helper;

public static class DomainHelper
{
    public static string GetDomainName(Type type)
    {
        if (type == null)
        {
            return string.Empty;
        }
        var fullName = type.FullName;
        return fullName.Substring(0, fullName.IndexOf('.', StringComparison.Ordinal));
    }

    public static string GetTypeName(Type type)
    {
        if (type == null)
        {
            return string.Empty;
        }
        var name = type.Name;
        if (name.Contains('`', StringComparison.Ordinal))
        {
            name = name.Substring(0, name.IndexOf('`', StringComparison.Ordinal));
        }
        return name;
    }
}
