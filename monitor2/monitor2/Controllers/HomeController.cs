using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace monitor2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your bu da tamam.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your burada.";
            ViewBag.Uyari = "Deneme 123";

            return View();
        }
    }
}