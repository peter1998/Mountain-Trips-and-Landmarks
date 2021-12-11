using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Data.ViewModels;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public class TracksService : EntityBaseRepository<Track>, ITracksService
    {
        private readonly AppDbContext _context;
        public TracksService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewTrack(NewTrackVm data)
        {
            //var newTrack = new Track()
            //{
            //    TrackCateogryURL = data.TrackCateogryURL,
            //    TrackCategory = data.TrackCategory,
            //    StartingPoint = data.StartingPoint,
            //    EndPoint = data.EndPoint,
            //    Highlights = data.Highlights,
            //    StartDate = data.StartDate,
            //    EndDate = data.EndDate,
            //    //LandmarkId = data.LandmarksIds
            //};
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Landmarks = await _context.Landmarks.OrderBy(n => n.Name).ToListAsync(),
                Peaks = await _context.Peaks.OrderBy(n => n.Name).ToListAsync(),
                Mountains = await _context.Mountains.OrderBy(n => n.Name).ToListAsync()
            };
            return response;
        }

        public async Task<Track> GetTrackByIdAsync(int id)
        {
            var trackDetails = _context.Tracks
               .Include(c => c.Mountain)
               .Include(c => c.Tracks_Peaks).ThenInclude(a => a.Peak)
               .Include(v => v.Tracks_Landmarks).ThenInclude(a => a.Landmark)
               .Include(m => m.Tracks_Mountains).ThenInclude(m => m.Mountain)
               .FirstOrDefaultAsync(n => n.Id == id);

            return await trackDetails;
        }
    }
}
