using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
 



        public ActionResult about()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult pricing()
        {
            return View();
        }
        public ActionResult project()
        {
            return View();
        }
        public ActionResult service()
        {
            return View();


        }
        public ActionResult projectdetails()
        {
            return View();
        }

       public ActionResult blogsidebar()
        {
            return View();
        }
        public ActionResult blogsingle()
        {
            return View();
        }
    }
}