using Mountain_Trips_and_Landmarks.Data;
using Mountain_Trips_and_Landmarks.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Track:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Starting from")]
        public string StartingPoint { get; set; }

        [Display(Name = "End Destination")]
        public string EndPoint { get; set; }

        [Display(Name = "Teams Organizations")]
        public string Highlights { get; set; }

        [Display(Name = "Start of Track")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End of Track")]
        public DateTime EndDate { get; set; }
        public TrackCategory TrackCategory { get; set; }

        public string TrackCateogryURL { get; set; }

        public float Longitude { get; set; }
        public float Latitude { get; set; }

        //Relationships

        public List<Tracks_Peaks> Tracks_Peaks { get; set; }

         public List<Tracks_Landmarks> Tracks_Landmarks { get; set; }

        public List<Tracks_Mountains> Tracks_Mountains { get; set; }

        //Mountain

        public int? MountainId { get; set; }

        public Mountain Mountain { get; set; }


        public int? PeakId { get; set; }

        public Peak Peak { get; set; }

        public int? LandmarkId { get; set; }
        public Landmark landmark { get; set; }
    }
}
