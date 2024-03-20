using System.Collections.Generic;
using System.Threading.Tasks;
using API.AmparoPet.Models;

namespace API.AmparoPet.Services
{
    public interface ICarerService
    {
        Task<Carer> GetCarerByIdAsync(int id);
        Task<List<Carer>> GetAllCareresAsync();
        Task<Carer> CreateCarerAsync(Carer address);
        Task<Carer> UpdateCarerAsync(Carer address);
        Task<bool> DeleteCarerAsync(int id);
    }
}
