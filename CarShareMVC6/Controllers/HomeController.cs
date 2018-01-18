using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShareMVC6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us: ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us at: ";

            return View();
        }

        public ActionResult NotFound()
        {
            ViewBag.Message = "Sorry, we do not provide routes in the selected region. Come back later.";
            return View();
        }
    }
}