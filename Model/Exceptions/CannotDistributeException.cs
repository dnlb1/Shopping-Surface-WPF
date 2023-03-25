using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exceptions
{
    public class CannotDistributeException : Exception
    {
        public CannotDistributeException()
        {
        }

        public CannotDistributeException(string message) : base(message)
        {
        }

        public CannotDistributeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotDistributeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
