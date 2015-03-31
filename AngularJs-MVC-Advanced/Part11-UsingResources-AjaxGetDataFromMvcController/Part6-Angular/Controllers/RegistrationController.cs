using Part6_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    public class RegistrationController : Controller
    {
        //Not working with fireFox - working with other browsers
        public ActionResult Index()
        {
            //var registrationModel = registratioVMBuilder.BuildRegistrationVM();
            return View();
        }
    }
}