using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public interface ITracksService: IEntityBaseRepository<Track>
    {
        Task<Track> GetTrackByIdAsync(int id);
    }
}
