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
        private readonly AppDbContext _context;
        public PeakService(AppDbContext context) :base(context)
        {
            _context = context;
        }

        public async Task<Peak> GetPeakByIdAsync(int id)
        {
            var peakDetails = _context.Peaks
               .Include(v => v.Peaks_Mountains)
               .Include(v=>v.Tracks_Peaks)
               .FirstOrDefaultAsync(n => n.Id == id);

            return await peakDetails;
        }
    }
}
