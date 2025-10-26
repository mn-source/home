using System;

namespace Home.Base.ExceptionHome
{
    [Serializable]
    public class DirectoryNotExistException : Exception
    {
        public DirectoryNotExistException()
        {
        }

        public DirectoryNotExistException(string message) : base(message)
        {
        }

        public DirectoryNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
