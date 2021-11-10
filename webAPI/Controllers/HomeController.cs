using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("WELCOME TO OUR APPLICATION");
        }

        [HttpPost]
        public IActionResult Post(JObject payLoad)
        {
            return Ok(payLoad);
        }
    }
}
