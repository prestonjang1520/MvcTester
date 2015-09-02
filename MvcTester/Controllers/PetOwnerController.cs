using MvcTester.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTester.Controllers
{
    public class PetOwnerController : Controller
    {
        //
        // GET: /PetOwner/

        public ActionResult Index()
        {
            mvctesterEntities1 _db = new mvctesterEntities1();
            ViewData.Model = (from m in _db.Petowners select m).ToList();

            return View();
        }

    }
}
