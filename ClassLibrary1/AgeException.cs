using System;
using System.Runtime.Serialization;

namespace ClassLibrary1
{
    public class AgeException : Exception
    {
        public AgeException() : base("Alder for lav")
        {
        }

        public AgeException(string message) : base(message)
        {
        }

        public AgeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
