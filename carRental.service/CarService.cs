using carRental.core.Models;
using carRental.core.Repositories;
using carRental.core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<Car> AddAsync(Car car)
        {
            await _carRepository.AddAsync(car);
            return car;
        }

        public async Task DeleteAsync(int id)
        {
            await _carRepository.DeleteByIdAsync(id);
            //Car c = cars.Find(x => x.id == id);
            //if (c != null)
            //    cars.Remove(c);
        }

        public async Task<List<Car>> GetAllAsync()
        {
            return await _carRepository.GetListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _carRepository.GetByIdAsync(id);
        }

        public async Task<Car> UpdateAsync(int id, Car car)
        {
            await _carRepository.UpdateAsync(id, car);
            return car;
            //Car c = cars.Find(x => x.id == id);
            //if (c != null)
            //{
            //    c.loc = car.loc;
            //    c.status = car.status;
            //    return;
            //}
            //car.id = ++idCounter;
            //cars.Add(car);
        }
    }
}
