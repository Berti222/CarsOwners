using CarsOwners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsOwners.Controllers
{
    public class OwnersController : Controller
    {
        CarsesOwnerEntities _context;

        public OwnersController()
        {
            _context = new CarsesOwnerEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Owners
        public ActionResult Index()
        {            
            return View(_context.Owners.ToList());
        }

        //  /create
        public ActionResult Create()
        {
            ViewBag.Heading = "Új";
            return View("OwnersForm", new Owners());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Owners owner)
        {
            if (!ModelState.IsValid)
                return View("OwnersForm", owner);

            if (owner == null)
                return HttpNotFound();

            Owners ownerInDB = _context.Owners.Where(x => x.Id == owner.Id).SingleOrDefault();

            if(ownerInDB != null)
            {
                ownerInDB.FirstName = owner.FirstName;
                ownerInDB.LastName = owner.LastName;
                ownerInDB.DateOfBirth = owner.DateOfBirth;                
            }
            else
            {
                _context.Owners.Add(owner);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // /edit/1
        public ActionResult Edit(int id)
        {
            Owners ownerInDB = _context.Owners.Where(x => x.Id == id).SingleOrDefault();

            if (ownerInDB == null)
                return HttpNotFound();

            ViewBag.Heading = "Szerkesztés";

            return View("OwnersForm",ownerInDB);
        }

        // /delete/1
        public ActionResult Delete(int id)
        {
            Owners ownerInDB = _context.Owners.Where(x => x.Id == id).SingleOrDefault();

            if (ownerInDB == null)
                return HttpNotFound();

            _context.Owners.Remove(ownerInDB);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}