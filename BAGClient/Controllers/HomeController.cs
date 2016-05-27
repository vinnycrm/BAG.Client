using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.CustomObject;
using BAG.BusinessLogic;

namespace BrewAgift.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult HeaderEvents()
        {
            EventsBLL oeventsBLL = new EventsBLL();
            var details = oeventsBLL.GetHeaderEvents(Convert.ToString(Session["UserId"]));
            return PartialView("HeaderEvents", details);
        }
    }
}