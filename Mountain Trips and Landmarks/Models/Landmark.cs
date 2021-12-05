using Mountain_Trips_and_Landmarks.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Landmark:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name="Landmark Picture")]
        [Required(ErrorMessage = "Landmark Picture is required")]
        public string LandmarkPictureURL { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Landmark Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Landmark Country is required")]
        public string Country { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
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
