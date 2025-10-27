﻿// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using System;

namespace Home.Base.ExceptionHome;

[Serializable]
public class UnknownDomainException : Exception
{
    public UnknownDomainException()
    {
    }

    public UnknownDomainException(string message) : base(message)
    {
    }

    public UnknownDomainException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
