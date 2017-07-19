using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Greeting = Hour < 12 ? "GOOD MORNING" : "GOOD EVENING";
            return View();
        }

        public ViewResult RSVPForm()
        {
            return View();
        }
    }
}