﻿using API.AmparoPet.Addresses.Repositories;
using API.AmparoPet.Models;

namespace API.AmparoPet.Addresses.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Address> GetAddressByIdAsync(int id)
        {
            return await _addressRepository.GetByIdAsync(id);
        }

        public async Task<List<Address>> GetAllAddressesAsync()
        {
            return await _addressRepository.GetAllAsync();
        }

        public async Task<Address> CreateAddressAsync(Address address)
        {
            return await _addressRepository.CreateAsync(address);
        }

        public async Task<Address> UpdateAddressAsync(Address address)
        {
            return await _addressRepository.UpdateAsync(address);
        }

        public async Task<bool> DeleteAddressAsync(int id)
        {
            return await _addressRepository.DeleteAsync(id);
        }
    }
}
