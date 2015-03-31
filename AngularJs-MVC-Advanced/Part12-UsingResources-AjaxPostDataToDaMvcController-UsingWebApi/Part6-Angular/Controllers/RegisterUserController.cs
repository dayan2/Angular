using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    public class RegisterUserController : ApiController
    {
        
        public HttpResponseMessage Post(StudentVM student)
        {
            return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            //return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}