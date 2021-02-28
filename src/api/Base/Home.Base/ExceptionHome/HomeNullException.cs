using System;
using System.Runtime.Serialization;

namespace Home.Base.ExceptionHome
{
    [Serializable]
    public class HomeNullException : Exception
    {
        public HomeNullException(string message) : base(message)
        {
        }

        public HomeNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public HomeNullException()
        {
        }



        protected HomeNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
