using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Tracks_Landmarks
    {
        public int? Id { get; set; }
        public int TrackId { get; set; }

        public Track Track { get; set; }

        public int? LandmarkId { get; set; }

        public Landmark Landmark { get; set; }
    }
}
