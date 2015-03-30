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
        public ActionResult Index()
        {
            var courses = GetSerializedCourses();
            return View("Index", "", courses);
        }

        private string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345}
            };

            //to make the serialized string convert into camelcase support string(otherwise view-angularJs code will not be able to read)
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }

    }
}
