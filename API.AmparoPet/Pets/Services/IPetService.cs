using System.Collections.Generic;
using System.Threading.Tasks;
using API.AmparoPet.Models;

namespace API.AmparoPet.Pets.Services
{
    public interface IPetService
    {
        Task<Pet> GetPetByIdAsync(int id);
        Task<List<Pet>> GetAllPetesAsync();
        Task<Pet> CreatePetAsync(Pet pet);
        Task<Pet> UpdatePetAsync(Pet pet);
        Task<bool> DeletePetAsync(int id);
    }
}
