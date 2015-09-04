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
        private mvctesterEntities1 _db = new mvctesterEntities1();

        //
        // GET: /PetOwner/

        public ActionResult Index()
        {
            ViewData.Model = (from m in _db.Petowners select m).ToList();

            return View();
        }

        /*
         * returns the Add PetOwner view
         * */
        public ActionResult Add()
        {
            return View();
        }

        /*
         * Receives a PetOwner object from the View with information provided by user. Gives the object
         * a unique PetOwnerID and adds it to the database.
         * 
         * Returns: redirects to the main page if successful, redisplays the 
         * */
        [HttpPost]
        public ActionResult Add(Petowner newOwner)
        {
            if (ModelState.IsValid)
            {
                int ownerId = 1;
                List<Petowner> owners = _db.Petowners.ToList();

                foreach (var owner in owners)
                {
                    if (ownerId == owner.PetOwnerID)    //checks if the id matches a current id in the db
                    {
                        ++ownerId;  //increments the id to ensure a unique id
                    }
                
                }

                newOwner.PetOwnerID = ownerId;
                _db.Petowners.Add(newOwner);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(newOwner);
        }

        /*
         * returns the Edit PetOwner view
         * */
        public ActionResult Edit(int id)
        {
            Petowner owner = _db.Petowners.Find(id);

            if (owner == null)
            {
                return this.HttpNotFound();
            }

            return View(owner);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Petowner owner)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(owner).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(owner);
        }

        public ActionResult Delete(int id)
        {
            Petowner owner = _db.Petowners.Find(id);

            if (owner == null)
            {
                return this.HttpNotFound();
            }

            return View(owner);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Petowner owner = _db.Petowners.Find(id);
            _db.Petowners.Remove(owner);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
