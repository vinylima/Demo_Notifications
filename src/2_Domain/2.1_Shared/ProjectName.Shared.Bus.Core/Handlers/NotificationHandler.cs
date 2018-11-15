
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using ProjectName.Shared.Bus.Core.Interfaces;
using ProjectName.Shared.Kernel.Core.Notifications;

namespace ProjectName.Shared.Bus.Core.Handlers
{
    public class NotificationHandler : INotificationHandler
    {
        private readonly List<Notification> _notifications;
        private readonly List<Warning> _warnings;
        private readonly List<SystemError> _systemErros;

        public NotificationHandler(List<Notification> notifications, List<Warning> warnings,
            List<SystemError> systemErrors)
        {
            this._notifications = notifications;
            this._warnings = warnings;
            this._systemErros = systemErrors;
        }

        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            this._notifications?.Add(notification);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}