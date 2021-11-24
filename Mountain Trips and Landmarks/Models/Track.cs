using Mountain_Trips_and_Landmarks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }

        public string StartingPoint { get; set; }

        public string EndPoint { get; set; }

        public string Highlights { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TrackCategory TrackCategory { get; set; }
    }
}
