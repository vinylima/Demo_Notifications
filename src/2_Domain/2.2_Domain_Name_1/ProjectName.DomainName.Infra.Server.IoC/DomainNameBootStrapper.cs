
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using ProjectName.DomainName.Infra.Server.Data.Context;
using ProjectName.DomainName.Infra.Server.Data.Repositories;
using ProjectName.DomainName.Domain.Interfaces.Repository;

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
            
            // Repositories

            services.AddScoped<IAddressRepository, AddressRepository>();
        }
    }
}