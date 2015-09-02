using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTester.Models;

namespace MvcTester.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            mvctesterEntities1 _db = new mvctesterEntities1();
            ViewBag.Message = "This is my MVC & Database Tester Application.";
            ViewData.Model = (from m in _db.Pets select m).ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This page describes my app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
