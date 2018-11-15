
using System;

using MediatR;

using ProjectName.Shared.Kernel.Core.Notifications;

namespace ProjectName.Shared.Bus.Core.Interfaces
{
    public interface INotificationHandler : INotificationHandler<Notification>, IDisposable
    {

    }
}