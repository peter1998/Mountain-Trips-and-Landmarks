using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class TracksService:EntityBaseRepository<Track>, ITracksService
    {
        private readonly AppDbContext _context;
        public TracksService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<Track> GetTrackByIdAsync(int id)
        {
            var trackDetails = _context.Tracks
               .Include(c => c.Mountain)
               .Include(c => c.Peak)
               .Include(v => v.Tracks_Landmarks).ThenInclude(a => a.Landmark)
               .FirstOrDefaultAsync(n => n.Id == id);

            return await trackDetails;
        }
    }
}
