
using System;

using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Web.API.Controllers
{
    public class BaseController : Controller
    {

        new public IActionResult Response(TimeSpan time, object response = null)
        {
            return Json(new
            {
                time = time,
                milliseconds = time.Milliseconds,
                ticks = time.Ticks,
                totalseconds = time.TotalSeconds,
                totalmilliseconds = time.TotalMilliseconds,
                response = response
            });
        }
    }
}