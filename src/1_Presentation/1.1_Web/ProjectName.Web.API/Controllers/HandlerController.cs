
using Microsoft.AspNetCore.Mvc;

using ProjectName.Shared.Bus.Abstractions;

namespace ProjectName.Web.API.Controllers
{
    public class HandlerController : BaseController
    {
        public HandlerController(IServiceBus serviceBus, INotificationStore notificationStore)
            : base(serviceBus, notificationStore)
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Save()
        {
            return Ok();
        }
    }
}