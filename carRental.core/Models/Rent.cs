using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Car Car { get; set; }
        public Renter Renter { get; set; }
    }
}
