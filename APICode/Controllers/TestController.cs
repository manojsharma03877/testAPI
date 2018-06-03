using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICode.Controllers
{
    public class TestController : ApiController
    {
        public IEnumerable<string> Hello()
        {
            return new string[] { "Hello", "world" };
        }

        [HttpGet]
        public IEnumerable<string> Hello(string id)
        {
            return new string[] { id, "world" };
        }

        [HttpGet]
        public IEnumerable<string> GoodBye()
        {
            return new string[] { "good bye", "world" };
        }
    }

}
