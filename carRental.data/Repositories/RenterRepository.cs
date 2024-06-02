using carRental.core.Models;
using carRental.core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace carRental.data.Repository
{
    public class RenterRepository : IRenterRepository
    {
        private readonly DataContext _context;

        public RenterRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Renter> AddAsync(Renter renter)
        {
            _context.Renters.Add(renter);
            await _context.SaveChangesAsync();
            return renter;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Renters.Remove(GetById(id).Result);
            await _context.SaveChangesAsync();
        }

        public async Task<Renter> GetById(int id)
        {
            return await _context.Renters.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Renter> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Renter>> GetList()
        {
            return await  _context.Renters.ToListAsync();
        }

        public Task<List<Renter>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Renter> UpdateAsync(int id, Renter renter)
        {
            Renter renterToUpdate = _context.Renters.ToList().Find(x => x.Id == id);
            if (renterToUpdate != null)
                _context.Renters.Remove(renterToUpdate);
            _context.Renters.Add(renter);
            await _context.SaveChangesAsync();
            return renter;
        }
    }
}
