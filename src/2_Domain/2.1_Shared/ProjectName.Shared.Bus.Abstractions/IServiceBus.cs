
using System;
using System.Threading.Tasks;

using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Shared.Bus.Abstractions
{
    public interface IServiceBus : IDisposable
    {
        Task SendCommand<T>(T command) where T : Command;

        Task<TResponse> SendCommand<T, TResponse>(T command) where T : Command<TResponse>;

        Task PublishEvent<T>(T @event) where T : Event;
    }
}