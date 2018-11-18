
using System;
using System.Threading;
using System.Threading.Tasks;

using ProjectName.DomainName.Application.Commands;
using ProjectName.Shared.Bus.Abstractions;

namespace ProjectName.DomainName.Handlers.Addresses
{
    public class SaveAddressCommandHandler : ICommandHandler<SaveAddressCommand>
    {
        public SaveAddressCommandHandler(IServiceProvider serviceProvider)
        {

        }

        public Task<bool> Handle(SaveAddressCommand request, CancellationToken cancellationToken)
        {
            bool executed = true;

            return Task.FromResult(executed);
        }
    }
}