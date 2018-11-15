
using System;

namespace ProjectName.Shared.Bus.Abstractions.ValueObjects
{
    public class Notification : Event
    {
        public Guid NotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Notification(string key, string value)
        {
            this.NotificationId = Guid.NewGuid();
            this.Key = key;
            this.Value = value;
        }
    }
}