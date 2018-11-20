
using System;

using ProjectName.DomainName.Application.ViewModels;
using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.DomainName.Application.Commands
{
    public class SearchAddressCommand : Command<string>
    {
        public SearchAddressCommand(Guid addressId)
            : base(addressId)
        {

        }
    }
}