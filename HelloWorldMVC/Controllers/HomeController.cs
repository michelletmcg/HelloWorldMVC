using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            if(day == DayOfWeek.Thursday)
            {
                //ViewBag is a wrapper around ViewData
                ViewBag.Message = "It's Thorsday!";
                
                //Same as above
                ViewData["Message"] = "It's Thorsday!";
            }
            else
            {
                ViewBag.Message = "Hulk Smash!";
            }

            //Data inside of ViewBag/ViewData is
            //automatically sent to the View
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public void Joe()
        {
            Response.Write("It's break time Joe!");
        }
    }
}