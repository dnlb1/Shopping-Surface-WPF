using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exceptions
{
    public class NotInException : Exception
    {
        public NotInException()
        {
        }

        public NotInException(string message) : base(message)
        {
        }

        public NotInException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
