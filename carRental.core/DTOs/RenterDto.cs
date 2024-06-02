using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.DTOs
{
    public class RenterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SumRents { get; set; }
        public float DiscountPercent { get; set; }
    }
}
