
using System.Collections.Generic;

using MediatR;
using Microsoft.Extensions.DependencyInjection;

using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Bus.Core.Handlers;
using ProjectName.Shared.Bus.Core.Store;
using ProjectName.Shared.Kernel.Core.Notifications;

namespace ProjectName.Shared.Infra.IoC
{
    public static class ServiceBusBootStrapper
    {
        public static void AddServiceBusModule(this IServiceCollection services)
        {
            services.AddScoped<List<Notification>>();
            services.AddScoped<List<Warning>>();
            services.AddScoped<List<SystemError>>();

            services.AddScoped<Bus.Core.Interfaces.INotificationHandler, NotificationHandler>();
            services.AddScoped<INotificationHandler<Notification>, NotificationHandler>();

            services.AddScoped<INotificationStore, NotificationStore>();
        }
    }
}