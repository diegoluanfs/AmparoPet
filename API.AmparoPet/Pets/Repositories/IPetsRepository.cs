using API.AmparoPet.Models;

namespace API.AmparoPet.Pets.Repositories
{
    public interface IPetRepository
    {
        Task<Pet> GetByIdAsync(int id);
        Task<List<Pet>> GetAllAsync();
        Task<Pet> CreateAsync(Pet pet);
        Task<Pet> UpdateAsync(Pet pet);
        Task<bool> DeleteAsync(int id);
    }
}
