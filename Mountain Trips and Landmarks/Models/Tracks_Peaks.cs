using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Tracks_Peaks
    {
       
        public int? Id { get; set; }
        public int? TrackId { get; set; }

        public Track Track { get; set; }

        public int? PeakId { get; set; }

        public Peak Peak { get; set; }
    }
}
