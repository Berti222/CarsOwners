using CarsOwners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarsOwners.Controllers
{
    public class OwnersCarsController : ApiController
    {
        CarsesOwnerEntities _context = new CarsesOwnerEntities();

        [HttpGet]
        public IEnumerable<Cars> Index()
        {
            return _context.Cars.ToList();
        }

        [HttpGet]
        public IHttpActionResult GetCars(int id)
        {
            IQueryable<SwitchTable> ownerCarsIds = _context.SwitchTable.Where(x => x.OwnersId == id);

            if (ownerCarsIds == null)
                return NotFound();

            IQueryable<Cars> cars = _context.Cars;

            List<CarDTO> ownerCars = new List<CarDTO>();

            foreach (var item in ownerCarsIds)
            {
                Cars car = cars.SingleOrDefault(x => x.Id == item.CarsId);

                if (car != null)
                {
                    CarDTO dto = new CarDTO();
                    dto.Id = item.Cars.Id;
                    dto.CarBrand = item.Cars.CarBrand;
                    dto.CarType = item.Cars.CarType;
                    dto.LicensePlateNumber = item.Cars.LicensePlateNumber;
                    dto.DateOfProduction = item.Cars.DateOfProduction;

                    ownerCars.Add(dto);
                }
            }
            return Ok(ownerCars);
        }
    }
}
