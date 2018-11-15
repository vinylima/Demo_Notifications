
using System;
using System.Threading.Tasks;

using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Shared.Bus.Abstractions
{
    public interface IServiceBus : IDisposable
    {
        Task PublishEvent<T>(T @event) where T : Event;
    }
}