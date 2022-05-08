using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Exceptions
{
    class TooYoungException : Exception
    {
        public TooYoungException()
        {
        }

        public TooYoungException(string message) : base(message)
        {
        }

        public TooYoungException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooYoungException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
