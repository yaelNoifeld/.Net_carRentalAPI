using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface IRentRepository
    {
        public Task<List<Rent>> GetListAsync();
        public Task<Rent> AddAsync(Rent rent);
        public Task<Rent> UpdateAsync(int id, Rent rent);
        public Task<Rent> GetByIdAsync(int id);
        public Task DeleteByIdAsync(int id);
    }
}
