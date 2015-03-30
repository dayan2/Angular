using Part6_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    //change the inheriting Controller to JsonController
    public class CourseController : JsonController
    {
        private readonly RegistratioVMBuilder registratioVMBuilder = new RegistratioVMBuilder();

        public ActionResult Index()
        {
            //get Courses into a list
            var courses = registratioVMBuilder.GetCourses();

            //send it as Json
            return Json(courses , JsonRequestBehavior.AllowGet);

            //Send Json to view(need to be converted into camelcase, to do that u need to create a JsonController)
            //And change the inheriting Controller to JsonController
        }
    }
}