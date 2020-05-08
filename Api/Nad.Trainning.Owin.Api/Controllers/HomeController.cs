using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Nad.Trainning.Owin.Api.Controllers
{
    [RoutePrefix("AccessControl/home")]
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello!!");
        }

        [Route("save")]
        [HttpPost]
        public string Post(string test)
        {
            return test;     
        }
    }
}