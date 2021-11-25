using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCoreWebApi.Models;

namespace TestCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMethod()
        {
            return Ok("Sample Output");
        }
        [HttpPost]
        public IActionResult PostMethod(Property property)
        {
            property.Status = "SUS0011";
            property.Message = "Successfully Fetched";
            property.Data = property.Data;
            return Ok(property);
        }

    }
}
