using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Services
{
    public interface ICarService
    {
        public Task<List<Car>> GetAllAsync();
        public Task<Car> GetByIdAsync(int id);
        public Task<Car> AddAsync(Car car);
        public Task<Car> UpdateAsync(int id, Car car);
        public Task DeleteAsync(int id);
    }
}
