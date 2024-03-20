using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.AmparoPet.Data;
using API.AmparoPet.Models;
using Microsoft.EntityFrameworkCore;

namespace API.AmparoPet.Repositories
{
    public class CarerRepository : ICarerRepository
    {
        private readonly AmparoPetContext _context;

        public CarerRepository(AmparoPetContext context)
        {
            _context = context;
        }

        public async Task<Carer> GetByIdAsync(int id)
        {
            return await _context.Caregivers.FindAsync(id);
        }

        public async Task<List<Carer>> GetAllAsync()
        {
            return await _context.Caregivers.ToListAsync();
        }

        public async Task<Carer> CreateAsync(Carer carer)
        {
            _context.Caregivers.Add(carer);
            await _context.SaveChangesAsync();
            return carer;
        }

        public async Task<Carer> UpdateAsync(Carer carer)
        {
            _context.Entry(carer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return carer;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var carer = await _context.Caregivers.FindAsync(id);
            if (carer == null)
                return false;

            _context.Caregivers.Remove(carer);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
