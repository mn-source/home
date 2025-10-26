// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using System;

namespace Home.Base.ExceptionHome
{
    public class DomainUpdateException : Exception
    {
        public DomainUpdateException()
        {
        }

        public DomainUpdateException(string message) : base(message)
        {
        }

        public DomainUpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
