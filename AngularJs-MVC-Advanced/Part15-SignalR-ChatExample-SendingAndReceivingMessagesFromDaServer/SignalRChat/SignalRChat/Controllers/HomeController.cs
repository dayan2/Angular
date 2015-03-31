using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        //Step1:Install the signalR extension from the nuget
        //step2:In Startup.css - add this inside the configuration method - app.MapSignalR();
        //step3:Create a SignalR Hb Class
        //step4:Create a Bundle in BundleConfig.cs for SignalR
        public ActionResult Index()
        {
            ViewBag.Message = "Index.";
            return View();
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