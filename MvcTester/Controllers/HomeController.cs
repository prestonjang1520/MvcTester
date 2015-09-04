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

            List<Pet> pets = _db.Pets.ToList();
            List<Petowner> owners = _db.Petowners.ToList();
            Dictionary<Petowner, List<Pet>> pairs = new Dictionary<Petowner,List<Pet>>();

            foreach (var o in owners)
            {
                List<Pet> ownersPets = new List<Pet>();

                foreach (var p in pets)
                {
                    if (p.PetOwnerID == o.PetOwnerID)
                    {
                        ownersPets.Add(p);
                    }
                }

                if (ownersPets.Count != 0)
                {
                    pairs.Add(o, ownersPets);
                }
            }

            ViewData.Model = pairs;

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
