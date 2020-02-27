using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsOwners.Models
{
    public class OwnerAndCarsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        public IEnumerable<CarDTO> Cars { get; set; }
    }
}