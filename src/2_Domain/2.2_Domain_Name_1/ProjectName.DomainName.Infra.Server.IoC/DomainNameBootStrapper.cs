
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using ProjectName.DomainName.Infra.Server.Data.Context;
using ProjectName.DomainName.Infra.Server.Data.Repositories;
using ProjectName.DomainName.Domain.Interfaces.Repository;
using ProjectName.Shared.Bus.Core;
using ProjectName.Shared.Bus.Abstractions;

namespace ProjectName.DomainName.Infra.Server.IoC
{
    public static class DomainNameBootStrapper
    {
        public static void AddDomainNameModule(this IServiceCollection services)
        {
            IConfiguration config = services.BuildServiceProvider().GetService<IConfiguration>();

            services.AddDbContext<DomainName_Context>(op =>
            {
                op.UseSqlServer(config.GetConnectionString("ProjectName_Connection"));
            });

            // Bus

            services.AddScoped<IServiceBus, ServiceBus>();

            // Handlers


            // Notification Store


            // Services

            //services.AddScoped<IAddressService, AddressService>();

            // Repository

            services.AddScoped<IAddressRepository, AddressRepository>();
        }
    }
}