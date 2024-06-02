using carRental.core.Models;

namespace carRental.Api.Models
{
    public class RentPostModel
    {
        public DateTime date { get; set; }
        public Car Car { get; set; }
    }
}
