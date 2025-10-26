using System;
using System.Runtime.Serialization;

namespace Home.Base.ExceptionHome
{
    [Serializable]
    public class InvalidFilePathException : Exception
    {
        public InvalidFilePathException()
        {
        }

        public InvalidFilePathException(string message) : base(message)
        {
        }

        public InvalidFilePathException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
