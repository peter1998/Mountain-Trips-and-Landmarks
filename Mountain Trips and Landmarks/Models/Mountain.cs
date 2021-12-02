using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Mountain
    {
        [Key]
        public int? MountainId { get; set; }

        [Display(Name ="Mountain Picture")]
        public string MountainPictureURL { get; set; }

        [Display(Name = "Mountain Name")]
        public string Name { get; set; }

        [Display(Name = "Trecking Time")]
        public int TrekkingTime { get; set; }

        [Display(Name = "Mountains Information and Facts")]
        public string Description { get; set; }

        //Relationships
        public List<Peaks_Mountains> Peaks_Mountains { get; set; }

        public List<Landmarks_Mountains> Landmarks_Mountains { get; set; }

        public List<Tracks_Mountains> Tracks_Mountains { get; set; }

        //Track 
        public List<Track> Tracks { get; set; }

        //Landmark 
        public List<Landmark> Landmarks { get; set; }

        //Peak
        public List<Peak> Peaks { get; set; }

    }
}
