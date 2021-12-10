using Mountain_Trips_and_Landmarks.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Mountain:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Mountain Picture")]
        [Required(ErrorMessage = "Mountain logo is required")]
        public string MountainPictureURL { get; set; }

        [Display(Name = "Mountain Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Display(Name = "Trecking Time")]
        [Required(ErrorMessage = "Trekking Time is required")]
        public int TrekkingTime { get; set; }

        [Display(Name = "Mountains Information and Facts")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Peaks_Mountains> Peaks_Mountains { get; set; }

        public List<Landmarks_Mountains> Landmarks_Mountains { get; set; }

        public List<Tracks_Mountains> Tracks_Mountains { get; set; }

        //Track 
        // public List<Track> Tracks { get; set; }


        // Откоментирай надолу ако се счупи логика свързана по-надълбоко с контролерите, трябва да добавя към mountain peak , както към track за да зарежда всичко. и да няма null reference при seed-ване.

       // Landmark
          public List<Landmark> Landmarks { get; set; }

      //  Peak
            public List<Peak> Peaks { get; set; }

        //public int? PeakId { get; set; }

        //public Peak Peak { get; set; }

        //public int? LandmarkId { get; set; }
        //public Landmark landmark { get; set; }

    }
}
