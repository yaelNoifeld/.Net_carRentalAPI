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
    public class RenterService : IRenterService
    {
        private readonly IRenterRepository _renterRepository;
        public RenterService(IRenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }

        public async Task<Renter> AddAsync(Renter renter)
        {
            await _renterRepository.AddAsync(renter);
            return renter;
        }

        public async Task DeleteAsync(int id)
        {
            await _renterRepository.DeleteAsync(id);
        }

        public async Task<List<Renter>> GetAllAsync()
        {
            return await _renterRepository.GetListAsync();
        }

        public async Task<Renter> GetByIdAsync(int id) => await _renterRepository.GetByIdAsync(id);

        public async Task<Renter> UpdateAsync(int id, Renter renter)
        {
            await _renterRepository.UpdateAsync(id, renter);
            return renter;
        }
    }

}
