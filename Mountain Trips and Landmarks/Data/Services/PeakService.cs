using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class PeakService : IPeakService
    {
        private readonly AppDbContext _context;

        public PeakService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Peak peak)
        {
           await _context.Peaks.AddAsync(peak);
           await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Peak>> GetAllAsync()
        {
            var result = await _context.Peaks.ToListAsync();
            return result;
        }

        public async Task<Peak> GetByIdAsync(int id)
        {
            var result = await _context.Peaks.FirstOrDefaultAsync(n => n.PeakId == id);
            return result;
        }

        public Peak Update(int id, Peak peak)
        {
            throw new NotImplementedException();
        }
    }
}
