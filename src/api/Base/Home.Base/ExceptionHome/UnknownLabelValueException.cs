// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using System;

namespace Home.Base.ExceptionHome
{
    [Serializable]
    public class UnknownLabelValueException : Exception
    {
        public UnknownLabelValueException()
        {
        }

        public UnknownLabelValueException(string message) : base(message)
        {
        }

        public UnknownLabelValueException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
