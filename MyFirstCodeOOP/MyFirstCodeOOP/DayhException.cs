using System;
using System.Runtime.Serialization;

namespace MyFirstCodeOOP
{
    [Serializable]
    internal class DayhException : Exception
    {
        public DayhException()
        {
        }

        public DayhException(string message) : base(message)
        {
        }

        public DayhException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DayhException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}