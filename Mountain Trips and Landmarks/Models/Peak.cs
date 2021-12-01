using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Peak
    {
        [Key]
        public int PeakId { get; set; }
        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Relationships
        public List<Peak_Mountain> Peaks_Mountains { get; set; }

        public List<Tracks_Peaks> Tracks_Peaks { get; set; }

        //Mountain
        public int MountainId { get; set; }

        public Mountain Mountain { get; set; }

        //Track
        
        public List<Track> Tracks { get; set; }

    }
}
