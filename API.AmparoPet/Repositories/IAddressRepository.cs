using API.AmparoPet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.AmparoPet.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetByIdAsync(int id);
        Task<List<Address>> GetAllAsync();
        Task<Address> CreateAsync(Address address);
        Task<Address> UpdateAsync(Address address);
        Task<bool> DeleteAsync(int id);
    }
}
