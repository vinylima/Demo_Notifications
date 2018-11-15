
using System;

using ProjectName.DomainName.Domain.ValueObjects;
using ProjectName.Shared.Domain;

namespace ProjectName.DomainName.Domain.Models
{
    public class Address : BaseModel<Address>
    {
        public string Street { get; set; }
        public City City { get; set; }

        public Address()
        {

        }

        public Address(Guid id, string street, string city)
        {
            this.Id = id;
            this.Street = street;
            this.City = new City
            {
                Name = city
            };
        }

        public Address(string street, string city)
        {
            this.Street = street;
            this.City = new City
            {
                Name = city
            };
        }

        public override void CopyTo(Address address)
        {
            address.Street = this.Street;
            address.City = this.City;
        }
    }
}