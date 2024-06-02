using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Services
{
    public interface IRentService
    {
        public Task<List<Rent>> GetAllAsync();
        public Task<Rent> GetByIdAsync(int id);
        public Task<Rent> AddAsync(Rent rent);
        public Task<Rent> UpdateAsync(int id, Rent rent);
        public Task DeleteAsync(int id);
    }
}
