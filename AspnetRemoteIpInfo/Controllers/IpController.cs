using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace AspnetRemoteIpInfo.Controllers
{
    [Route("api/ip")]
    public class IpController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetIp()
        {
            return Ok(new
            {
                ClientIpHttpContext = HttpContext.Connection.RemoteIpAddress.ToString(),
                ClientIpHeader = Request.Headers["X-Client-IP"].ToString()
            });
        }
    }
}
