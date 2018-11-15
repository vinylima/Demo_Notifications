
using System;

using MediatR;

namespace ProjectName.Shared.Bus.Abstractions.ValueObjects
{
    public class Event : Message, INotification
    {
        public DateTime Time { get; private set; }

        protected Event()
        {
            this.Time = DateTime.Now;
        }
    }
}