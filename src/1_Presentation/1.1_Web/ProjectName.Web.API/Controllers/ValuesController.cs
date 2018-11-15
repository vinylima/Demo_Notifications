
using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using ProjectName.Shared.Bus.Abstractions;
using ProjectName.Shared.Kernel.Core.Notifications;

namespace DemoRepository.Web.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IServiceBus _serviceBus;
        private readonly INotificationStore _notificationStore;

        public ValuesController(INotificationStore notificationStore, IServiceBus serviceBus)
        {
            this._notificationStore = notificationStore;
            this._serviceBus = serviceBus;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            this._serviceBus.PublishEvent(new Notification("Key", "Value!!!"));


            return new string[] { "value1", "value2" };
        }
    }
}
