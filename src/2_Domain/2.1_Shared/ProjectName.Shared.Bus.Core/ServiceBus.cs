
using System;
using System.Threading.Tasks;

using MediatR;

using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Kernel.Core.Notifications;

namespace ProjectName.Shared.Bus.Core
{
    public class ServiceBus : IServiceBus
    {
        private readonly IMediator _mediator;

        public ServiceBus(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task PublishEvent<T>(T @event) where T : Event
        {
            try
            {
                await this._mediator.Publish(@event);
            }
            catch(Exception e)
            {

            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}