
using System.Threading;
using System.Threading.Tasks;

using ProjectName.DomainName.Application.Commands.AddressCommands;
using ProjectName.Shared.Bus.Abstractions;

namespace ProjectName.DomainName.Handlers.Addresses
{
    public class SearchAddressCommandHandler //: ICommandHandler<SearchAddressCommand>
    {
        public Task<bool> Handle(SearchAddressCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
