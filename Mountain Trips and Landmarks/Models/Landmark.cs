using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Landmark
    {
        [Key]
        public int LandmarksId { get; set; }
        
        [Display(Name="Landmark Picture")]
        public string LandmarkPictureURL { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Mountain
        public int? MountainId { get; set; }

        public Mountain Mountain { get; set; }

        //Track 
        public List<Track> Tracks { get; set; }



          public List<Tracks_Landmarks> Tracks_Landmarks { get; set; }

         public List<Landmarks_Mountains> Landmarks_Mountains { get; set; }

    }
}
