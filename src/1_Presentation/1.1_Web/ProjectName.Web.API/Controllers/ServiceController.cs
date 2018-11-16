
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Web.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ServiceController : BaseController
    {
        public ServiceController(IServiceBus serviceBus, INotificationStore notificationStore)
            : base(serviceBus, notificationStore)
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            base.ServiceBus.PublishEvent(new Notification("Key", "Value!!!"));

            return Response();
        }

        // GET api/Service/Save
        [HttpPost]
        public IActionResult Save()
        {
            base.ServiceBus.PublishEvent(new Notification("Key", "Value!!!"));
            
            return Response();
        }
    }
}
