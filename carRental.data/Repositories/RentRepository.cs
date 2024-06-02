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
    public class RentRepository : IRentRepository
    {
        private readonly DataContext _context;
        public RentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Rent> AddAsync(Rent rent)
        {
            _context.Rents.Add(rent);
            await _context.SaveChangesAsync();
            return rent;
        }

        public async Task DeleteByIdAsync(int id)
        {
            _context.Rents.Remove(GetById(id).Result);
            await _context.SaveChangesAsync();
        }

        public async Task<Rent> GetById(int id)
        {
            return await _context.Rents.Include(r=>r.Car).Include(r=>r.Renter).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Rent> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Rent>> GetList()
        {
            return await _context.Rents.Include(r => r.Car).Include(r => r.Renter).ToListAsync();
        }

        public Task<List<Rent>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Rent> UpdateAsync(int id, Rent rent)
        {
            Rent rentToUpdate = _context.Rents.ToList().Find(x => x.Id == id);
            if (rentToUpdate != null)
                _context.Rents.Remove(rentToUpdate);
            _context.Rents.Add(rent);
            await _context.SaveChangesAsync();
            return rent;
        }
    }
}
