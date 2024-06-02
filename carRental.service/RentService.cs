using carRental.core.Models;
using carRental.core.Repositories;
using carRental.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.service
{
    public class RentService : IRentService
    {
        private readonly IRentRepository _rentRepository;
        public RentService(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public async Task<Rent> AddAsync(Rent rent)
        {
            await _rentRepository.AddAsync(rent);
            return rent;
        }

        public async Task DeleteAsync(int id)
        {
            await _rentRepository.DeleteByIdAsync(id);
        }

        public async Task<List<Rent>> GetAllAsync()
        {
            return await _rentRepository.GetListAsync();
        }

        public async Task<Rent> GetByIdAsync(int id) => await _rentRepository.GetByIdAsync(id);

        public async Task<Rent> UpdateAsync(int id, Rent rent)
        {
            await _rentRepository.UpdateAsync(id, rent);
            return rent;
        }
    }
}
