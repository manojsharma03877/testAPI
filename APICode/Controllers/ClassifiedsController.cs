using APICode.BLL;
using APICode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICode.Controllers
{
    public class ClassifiedsController : ApiController
    {
        public List<ClassifiedModel> Get(string id)
        {
            return ClassifiedService.GetClassifieds(id);
        }
        public List<ClassifiedModel> Get()
        {
            return ClassifiedService.GetClassifieds("");
        }
    }
}
