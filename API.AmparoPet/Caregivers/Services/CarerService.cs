﻿using API.AmparoPet.Caregivers.Repositories;
using API.AmparoPet.Models;

namespace API.AmparoPet.Caregivers.Services
{
    public class CarerService : ICarerService
    {
        private readonly ICarerRepository _carerRepository;

        public CarerService(ICarerRepository carerRepository)
        {
            _carerRepository = carerRepository;
        }

        public async Task<Carer> GetCarerByIdAsync(int id)
        {
            return await _carerRepository.GetByIdAsync(id);
        }

        public async Task<List<Carer>> GetAllCareresAsync()
        {
            return await _carerRepository.GetAllAsync();
        }

        public async Task<Carer> CreateCarerAsync(Carer carer)
        {
            return await _carerRepository.CreateAsync(carer);
        }

        public async Task<Carer> UpdateCarerAsync(Carer carer)
        {
            return await _carerRepository.UpdateAsync(carer);
        }

        public async Task<bool> DeleteCarerAsync(int id)
        {
            return await _carerRepository.DeleteAsync(id);
        }
    }
}
