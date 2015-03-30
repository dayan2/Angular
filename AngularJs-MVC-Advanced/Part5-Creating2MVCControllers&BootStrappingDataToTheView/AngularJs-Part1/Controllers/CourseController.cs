using AngularJs_Part1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJs_Part1.Controllers
{
    public class CourseController : Controller
    {
        //step 1 - Goto Nuget and download bootstrap,jquery,Json.Net,AngualarJs

        private RegistratioVMBuilder registratioVMBuilder = new RegistratioVMBuilder();

        public ActionResult Index()
        {
            var courses = registratioVMBuilder.GetSerializedCourses();
            return View("Index", "", courses);
        }

        

    }
}
