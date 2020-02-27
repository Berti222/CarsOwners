using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsOwners.Models
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarType { get; set; }
        public string LicensePlateNumber { get; set; }
        public Nullable<System.DateTime> DateOfProduction { get; set; }
    }
}