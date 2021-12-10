using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Tracks_Peaks
    {
        //Comment this if not update-base after migration: Goal to add to tracklist , list with peaks
        public int? Id { get; set; }
        public int? TrackId { get; set; }

        public Track Track { get; set; }

        public int? PeakId { get; set; }

        public Peak Peak { get; set; }
    }
}
