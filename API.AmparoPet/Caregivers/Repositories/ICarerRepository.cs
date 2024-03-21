using API.AmparoPet.Models;

namespace API.AmparoPet.Caregivers.Repositories
{
    public interface ICarerRepository
    {
        Task<Carer> GetByIdAsync(int id);
        Task<List<Carer>> GetAllAsync();
        Task<Carer> CreateAsync(Carer carer);
        Task<Carer> UpdateAsync(Carer carer);
        Task<bool> DeleteAsync(int id);
    }
}
