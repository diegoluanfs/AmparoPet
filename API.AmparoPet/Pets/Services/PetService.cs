using API.AmparoPet.Models;
using API.AmparoPet.Pets.Repositories;

namespace API.AmparoPet.Pets.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<Pet> GetPetByIdAsync(int id)
        {
            return await _petRepository.GetByIdAsync(id);
        }

        public async Task<List<Pet>> GetAllPetesAsync()
        {
            return await _petRepository.GetAllAsync();
        }

        public async Task<Pet> CreatePetAsync(Pet pet)
        {
            return await _petRepository.CreateAsync(pet);
        }

        public async Task<Pet> UpdatePetAsync(Pet pet)
        {
            return await _petRepository.UpdateAsync(pet);
        }

        public async Task<bool> DeletePetAsync(int id)
        {
            return await _petRepository.DeleteAsync(id);
        }
    }
}
