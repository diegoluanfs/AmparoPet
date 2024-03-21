using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.AmparoPet.Data;
using API.AmparoPet.Models;
using Microsoft.EntityFrameworkCore;

namespace API.AmparoPet.Pets.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly AmparoPetContext _context;

        public PetRepository(AmparoPetContext context)
        {
            _context = context;
        }

        public async Task<Pet> GetByIdAsync(int id)
        {
            return await _context.Pets.FindAsync(id);
        }

        public async Task<List<Pet>> GetAllAsync()
        {
            return await _context.Pets.ToListAsync();
        }

        public async Task<Pet> CreateAsync(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return pet;
        }

        public async Task<Pet> UpdateAsync(Pet pet)
        {
            _context.Entry(pet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return pet;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
                return false;

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
