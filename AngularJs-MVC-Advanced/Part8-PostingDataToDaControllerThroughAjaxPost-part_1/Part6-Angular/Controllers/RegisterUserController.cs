using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    public class RegisterUserController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVM student)
        {

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}