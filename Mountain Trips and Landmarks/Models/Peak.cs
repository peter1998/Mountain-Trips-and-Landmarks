using Mountain_Trips_and_Landmarks.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Peak: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture View")]
        [Required(ErrorMessage ="Peak Picture is required")]
        public string Logo { get; set; }

        [Display(Name = "Peak Name")]
        [Required(ErrorMessage = "Peak Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage = "Peak Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Peak story is required")]
        public string Description { get; set; }

        //Relationships
        public List<Peaks_Mountains> Peaks_Mountains { get; set; }

        public List<Tracks_Peaks> Tracks_Peaks { get; set; }

        //Track
       public List<Track> Tracks { get; set; }
        //public int PeakId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public List<Mountain> Mountains { get; set; }


    }
}
