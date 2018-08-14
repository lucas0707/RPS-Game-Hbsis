using System;
using System.Runtime.Serialization;

namespace RPS_Game
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError()
        {
        }

        public NoSuchStrategyError(string message) : base(message)
        {
        }

        public NoSuchStrategyError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchStrategyError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
