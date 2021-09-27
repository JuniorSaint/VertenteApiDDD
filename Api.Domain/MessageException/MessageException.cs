using System;

namespace Api.Domain.MessageException
{
    public class MessageException : Exception
    {
        public MessageException(string message) : base(message)
        {
        }
    }
}

