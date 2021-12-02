using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Tracks_Mountains
    {
        public int Id { get; set; }
        public int? TrackId { get; set; }

        public Track Track { get; set; }

        public int? MountainId { get; set; }

        public Mountain Mountain { get; set; }
    }
}
