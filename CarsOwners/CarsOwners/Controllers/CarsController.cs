using CarsOwners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsOwners.Controllers
{
    public class CarsController : Controller
    {
        CarsesOwnerEntities _context;

        public CarsController()
        {
            _context = new CarsesOwnerEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Cars
        public ActionResult Index()
        {
            return View(_context.Cars.ToList());
        }

        //  /create
        public ActionResult Create()
        {
            ViewBag.Heading = "Új";
            return View("CarsForm", new Cars());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Cars car)
        {
            if (!ModelState.IsValid)
                return View("CarsForm", car);

            if (car == null)
                return HttpNotFound();

            Cars carInDB = _context.Cars.Where(x => x.Id == car.Id).SingleOrDefault();

            if (carInDB != null)
            {
                carInDB.CarBrand = car.CarBrand;
                carInDB.CarType = car.CarType;
                carInDB.LicensePlateNumber = car.LicensePlateNumber;
                carInDB.DateOfProduction = car.DateOfProduction;
            }
            else
            {
                _context.Cars.Add(car);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // /edit/1
        public ActionResult Edit(int id)
        {
            Cars carInDB = _context.Cars.Where(x => x.Id == id).SingleOrDefault();

            if (carInDB == null)
                return HttpNotFound();

            ViewBag.Heading = "Szerkesztés";

            return View("CarsForm", carInDB);
        }

        // /delete/1
        public ActionResult Delete(int id)
        {
            Cars carInDB = _context.Cars.Where(x => x.Id == id).SingleOrDefault();

            if (carInDB == null)
                return HttpNotFound();

            _context.Cars.Remove(carInDB);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}