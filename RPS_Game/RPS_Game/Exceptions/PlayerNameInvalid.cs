using System;
using System.Runtime.Serialization;

namespace RPS_Game
{
    public class PlayerNameInvalid : Exception
    {
        public PlayerNameInvalid()
        {
        }
        
        public PlayerNameInvalid(string message) : base(message)
        {
        }

        public PlayerNameInvalid(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PlayerNameInvalid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
