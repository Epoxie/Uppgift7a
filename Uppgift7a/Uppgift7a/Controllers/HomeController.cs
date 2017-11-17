using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uppgift7a.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Edit";

            return View();
        }
    }
}
