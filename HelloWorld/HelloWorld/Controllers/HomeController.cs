using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHome()
        {
            return View("MyHomePage");
        }

        public ActionResult Test()
        {
            return View("MyHomePage");
        }

        public ActionResult CurrentTime()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View("MyHomePage");
        }
    }
}