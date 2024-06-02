using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface ICarRepository
    {
        public Task<List<Car>> GetListAsync();
        public Task<Car> AddAsync(Car car);
        public Task<Car> UpdateAsync(int id, Car car);
        public Task<Car> GetByIdAsync(int id);
        public Task DeleteByIdAsync(int id);
    }
}
