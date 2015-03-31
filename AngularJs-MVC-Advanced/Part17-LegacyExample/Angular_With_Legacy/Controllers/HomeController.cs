using Angular_With_Legacy.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace Angular_With_Legacy.Controllers
{
    public class HomeController : JsonController
    {
        public ActionResult Index()
        {

            User user = new User { ID = 1, Name = "Dayan Mendis" };

            //return Json(user , JsonRequestBehavior.AllowGet);
            string json = JsonConvert.SerializeObject(user);
            return View("Index", "", json);
        }


        public ActionResult GetCurrentUser()
        {
            User user = new User { ID = 2, Name = "Krishan Mendis" };

            //return Json(user , JsonRequestBehavior.AllowGet);
            //string json = JsonConvert.SerializeObject(user);
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCatalog()
        {
            var list = GetCatalogList();

            //send it as Json
            return Json(list, JsonRequestBehavior.AllowGet);

            //Send Json to view(need to be converted into camelcase, to do that u need to create a JsonController)
            //And change the inheriting Controller to JsonController
        }

        private List<Course> GetCatalogList()
        {
            List<Course> list = new List<Course>
            {
                new Course{iD = 1, credits = 200, instructorName = "Jon Doe", name = "Neranjan Mendis"},
                new Course{iD = 2, credits = 600, instructorName = "John King", name = "Dayan Mendis"},
                new Course{iD = 3, credits = 900, instructorName = "Jona Lu", name = "Ewerdney Mendis"},
                new Course{iD = 4, credits = 100, instructorName = "Joge Luna", name = "Dan Mendis"}
            };
            return list;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}