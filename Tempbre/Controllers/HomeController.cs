using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tempbre.Models;
using System.IO;

namespace Timbre.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your music, in your hands";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
        [HttpGet]
        public ActionResult Download()
        {
            FilePathResult fpr = new FilePathResult("~\\File\\Download.txt", "text/plain");
            return View(fpr);
        }
    }
}