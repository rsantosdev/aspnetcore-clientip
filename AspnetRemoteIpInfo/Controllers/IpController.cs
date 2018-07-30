using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
                ClientIp = HttpContext.Connection.RemoteIpAddress.ToString()
            });
        }
    }
}
