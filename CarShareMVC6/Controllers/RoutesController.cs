using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarShareMVC6.Models;

namespace CarShareMVC6.Controllers
{
    public class RoutesController : Controller
    {
        CarShareDB6Entities db = new CarShareDB6Entities();

        // GET: RouteShare
        public ActionResult Index()
        {
            var routes = from r in db.Routes
                         select r;
            return View(routes.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.DepartingPoint = new SelectList(db.Cities, "CityName");
            return View();
            
        }

        [HttpPost]
        public ActionResult Create(Route newRoute)
        {
            if (ModelState.IsValid)
            {
                db.Routes.Add(newRoute);
                db.SaveChanges();
                ViewBag.DepartingPoint = new SelectList(db.Cities, "CityName", newRoute.DepartingPoint);
                return RedirectToAction("Index");
            }
            else
                return View(newRoute);
        }

        //[HttpGet]
        public ActionResult Details(Route r)
        {
            return View(r);
        }

        public ActionResult SearchRoute(string departingPoint)
        {
            var routeModel = from r in db.Routes where r.DepartingPoint == departingPoint select r;
            return View(routeModel.ToList());
        }
    }
}