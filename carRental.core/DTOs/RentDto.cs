using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.DTOs
{
    public class RentDto
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Car Car { get; set; }
    }
}
