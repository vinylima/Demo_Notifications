
using System;

using MediatR;

using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Shared.Bus.Core.Interfaces
{
    public interface INotificationHandler : INotificationHandler<Notification>, IDisposable
    {

    }
}