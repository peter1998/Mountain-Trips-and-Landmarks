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
        public List<Peaks_Mountains> Peaks_Mountains { get; set; }

        public List<Tracks_Peaks> Tracks_Peaks { get; set; }

        //Track
       public List<Track> Tracks { get; set; }
      //  public List<Mountain> Mountains { get; set; }


    }
}
