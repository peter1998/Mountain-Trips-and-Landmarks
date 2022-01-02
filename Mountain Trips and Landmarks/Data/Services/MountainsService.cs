using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class MountainsService:EntityBaseRepository<Mountain>, IMountainsService
    {
        private readonly AppDbContext _context;
        public MountainsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Mountain> GetMountainByIdAsync(int id)
        {
            var mountainDetails = _context.Mountains
              .Include(v => v.Tracks_Mountains)
              .Include(v => v.Peaks_Mountains)
              .Include(v=>v.Landmarks_Mountains)
              .FirstOrDefaultAsync(n => n.Id == id);

            return await mountainDetails;
        }


    }
}
