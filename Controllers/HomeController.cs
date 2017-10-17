using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EzUtility.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ez()
        {
            ViewData["Message"] = "Welcome to EzPatch";
            return View();
        }

    }
}