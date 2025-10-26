﻿// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using System;

namespace Home.Base.ExceptionHome
{
    [Serializable]
    public class FileHashConflictException : Exception
    {
        public FileHashConflictException(string fileHash) : base($"File hash {fileHash} already exist.")
        {
        }

        public FileHashConflictException()
        {
        }

        public FileHashConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
