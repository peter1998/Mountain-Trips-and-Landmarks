using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class PeakService : EntityBaseRepository<Peak>,
        IPeakService
    {
        

        public PeakService(AppDbContext context) :base(context)
        {
            
        }

        //public async Task AddAsync(Peak peak)
        //{
        //   await _context.Peaks.AddAsync(peak);
        //   await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Peaks.FirstOrDefaultAsync(n => n.PeakId == id);
        //    _context.Peaks.Remove(result);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Peak>> GetAllAsync()
        //{
        //    var result = await _context.Peaks.ToListAsync();
        //    return result;
        //}

        //public async Task<Peak> GetByIdAsync(int id)
        //{
        //    var result = await _context.Peaks.FirstOrDefaultAsync(n => n.PeakId == id);
        //    return result;
        //}

        //public async Task<Peak> UpdateAsync(int id, Peak newPeak)
        //{
        //    // moe podobrenie
        //    newPeak.PeakId = id;
        //    // moe podobrenie
        //    var peakForDelete = _context.Peaks.ToList().FirstOrDefault(n => n.PeakId == id);
        //    _context.Remove(peakForDelete);
        //    _context.Update(newPeak);
        //    await _context.SaveChangesAsync();
        //    return newPeak;
        //}
    }
}
