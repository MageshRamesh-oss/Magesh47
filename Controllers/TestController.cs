using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication35.Models;

namespace WebApplication35.Controllers
{
   
    [Route("api/test")]
    public class TestController : ApiController
    {
        public TestController()
        {

        }

        [HttpGet]
        public IHttpActionResult GetElement()
        {
            return Ok("Simple Content");
        }
        [HttpPost]
        public IHttpActionResult PostElement([FromBody]DummyClass dummyClass)
        {
            dummyClass.Status = "SUC0077";
            dummyClass.Message = "Successfully Fetched";
            dummyClass.data = dummyClass.data;

            return Ok(dummyClass);
        }
    }
}
