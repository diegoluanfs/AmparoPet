using API.AmparoPet.Models;

namespace API.AmparoPet.Caregivers.Services
{
    public interface ICarerService
    {
        Task<Carer> GetCarerByIdAsync(int id);
        Task<List<Carer>> GetAllCareresAsync();
        Task<Carer> CreateCarerAsync(Carer carer);
        Task<Carer> UpdateCarerAsync(Carer carer);
        Task<bool> DeleteCarerAsync(int id);
    }
}
