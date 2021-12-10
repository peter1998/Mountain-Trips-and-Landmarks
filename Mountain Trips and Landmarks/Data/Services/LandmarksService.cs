using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class LandmarksService: EntityBaseRepository<Landmark>,
        ILandmarksService
    {

        private readonly AppDbContext _context;
        public LandmarksService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Landmark> GetLandmarkByIdAsync(int id)
        {
            var landmarkDetails = _context.Landmarks
                .Include(v=> v.Tracks_Landmarks)
                .Include(v=>v.Landmarks_Mountains)
                .Include(v=>v.Tracks)
               .FirstOrDefaultAsync(n => n.Id == id);

            return await landmarkDetails;
        }
    }
}
