using API.AmparoPet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.AmparoPet.Repositories
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
