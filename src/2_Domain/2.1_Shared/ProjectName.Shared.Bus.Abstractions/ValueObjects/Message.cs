
using System;

namespace ProjectName.Shared.Bus.Abstractions.ValueObjects
{
    public class Message
    {
        public Type MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            this.MessageType = this.GetType();
        }
    }
}