using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Exceptions
{
    class IncorrectEmailException : Exception
    {
        public IncorrectEmailException()
        {
        }

        public IncorrectEmailException(string message) : base(message)
        {
        }

        public IncorrectEmailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
