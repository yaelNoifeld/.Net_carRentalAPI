using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface IRenterRepository
    {
        public Task<List<Renter>> GetListAsync();
        public Task<Renter> AddAsync(Renter renter);
        public Task<Renter> UpdateAsync(int id, Renter renter);
        public Task<Renter> GetByIdAsync(int id);
        public Task DeleteAsync(int id);
    }
}
