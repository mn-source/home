using Microsoft.AspNetCore.Mvc;

namespace Home.Client.Api.Controllers.Base
{
    [Controller]
    public abstract class BaseController : ControllerBase
    {

        protected string IpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            else
            {
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            }
        }
    }
}
