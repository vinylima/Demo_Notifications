
using System;
using System.Threading.Tasks;

using MediatR;

using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Shared.Bus.Core
{
    public class ServiceBus : IServiceBus
    {
        private readonly IMediator _mediator;
        private Guid id;

        public ServiceBus(IMediator mediator)
        {
            this._mediator = mediator;
            this.id = Guid.NewGuid();
        }

        public async Task PublishEvent<T>(T @event) where T : Event
        {
            await this._mediator.Publish(@event);
        }
        
        public async Task SendCommand<T>(T command) where T : Command
        {
            await this._mediator.Send(command);
        }

        public async Task<TResponse> SendCommand<T, TResponse>(T command) where T : Command<TResponse>
        {
            TResponse response = await this._mediator.Send(command);
            
            return response;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}