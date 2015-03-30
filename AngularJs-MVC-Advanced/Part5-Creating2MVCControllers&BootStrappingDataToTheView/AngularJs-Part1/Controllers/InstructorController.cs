using AngularJs_Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJs_Part1.Controllers
{
    public class InstructorController : Controller
    {
        private RegistratioVMBuilder registratioVMBuilder = new RegistratioVMBuilder();

        public ActionResult Index()
        {
            var instructors = registratioVMBuilder.GetSerializedInstructors();
            return View("Index", "", instructors);
        }
    }
}
