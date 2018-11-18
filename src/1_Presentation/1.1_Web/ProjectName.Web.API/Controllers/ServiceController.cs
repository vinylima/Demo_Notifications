
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ProjectName.DomainName.Application.Commands;
using ProjectName.DomainName.Application.ViewModels;
using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Web.API.Controllers
{
    public class ServiceController : BaseController
    {
        public ServiceController(IServiceBus serviceBus, INotificationStore notificationStore, IServiceProvider serviceProvider)
            : base(serviceBus, notificationStore)
        {
            var bus = serviceProvider.GetService(typeof(IServiceBus));
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Index()
        {
            base.ServiceBus.PublishEvent(new Notification("Key", "Value!!!"));

            return Response();
        }

        // GET api/Service/Save
        [HttpPost]
        [Route("api/[controller]/Save")]
        public IActionResult Save([FromBody] SaveAddressCommand addressViewModel)
        {
            this.ServiceBus.SendCommand(addressViewModel);
            
            return Response();
        }
    }
}
