using carRental.core.Models;
using carRental.core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace carRental.data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Car> AddAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task DeleteByIdAsync(int id)
        {
            _context.Cars.Remove(GetByIdAsync(id).Result);
            await _context.SaveChangesAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Car>> GetListAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> UpdateAsync(int id, Car car)
        {
            Car carToUpdate = _context.Cars.ToList().Find(x => x.Id == id);
            if (carToUpdate != null)
                _context.Cars.Remove(carToUpdate);
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }
    }
}
