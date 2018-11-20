﻿
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using MediatR;

using ProjectName.DomainName.Application.Commands.AddressCommands;
using ProjectName.DomainName.Domain.Interfaces.Repository;
using ProjectName.DomainName.Handlers.Addresses;
using ProjectName.DomainName.Infra.Server.Data.Context;
using ProjectName.DomainName.Infra.Server.Data.Repositories;

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
            services.AddScoped<IAddressReadRepository, AddressRepository>();


            // Handlers

            services.AddScoped<IRequestHandler<SaveAddressCommand, bool>, SaveAddressCommandHandler>();
        }
    }
}