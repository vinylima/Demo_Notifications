
using System;

namespace ProjectName.Shared.Kernel.Core.Notifications
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