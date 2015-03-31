using Part6_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Part6_Angular.Controllers
{
    //change the inheriting Controller to ApiController
    public class CourseController : ApiController
    {
        private readonly RegistratioVMBuilder registratioVMBuilder = new RegistratioVMBuilder();

        public CourseVM[] Get()
        {
            //get Courses into a list
            var courses = registratioVMBuilder.GetCourses();


            return courses;
            //Send Json to view(need to be converted into camelcase), it is done in the webApiConfig.cs file
            //And change the inheriting Controller to ApiController
            //Change the method's name to Get
            //Insert this in Global.asax - //Need to add this to work 
            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}