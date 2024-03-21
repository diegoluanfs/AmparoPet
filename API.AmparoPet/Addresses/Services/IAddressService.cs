using System.Collections.Generic;
using System.Threading.Tasks;
using API.AmparoPet.Models;

namespace API.AmparoPet.Addresses.Services
{
    public interface IAddressService
    {
        Task<Address> GetAddressByIdAsync(int id);
        Task<List<Address>> GetAllAddressesAsync();
        Task<Address> CreateAddressAsync(Address address);
        Task<Address> UpdateAddressAsync(Address address);
        Task<bool> DeleteAddressAsync(int id);
    }
}
