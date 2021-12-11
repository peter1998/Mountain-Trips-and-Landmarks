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
    public class NewTrackVm
    {
        [Display(Name = "Track Starting destination from: ")]
        [Required(ErrorMessage ="StartingPoint is required")]
        public string StartingPoint { get; set; }

        [Display(Name = "Track End point")]
        [Required(ErrorMessage = "EndPoint is required")]
        public string EndPoint { get; set; }

        [Display(Name = "Track Organization/Company")]
        [Required(ErrorMessage = "Highlights is required")]
        public string Highlights { get; set; }

        [Display(Name = "Track Start Date")]
        [Required(ErrorMessage = "StartDate is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Track End Date")]
        [Required(ErrorMessage = "EndDate is required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Track Category")]
        [Required(ErrorMessage = "TrackCategory is required")]
        public TrackCategory TrackCategory { get; set; }

        [Display(Name = "Track Category Image")]
        [Required(ErrorMessage = "Track Category ImageUrl is required")]
        public string TrackCateogryURL { get; set; }

        //Relationships

        [Display(Name = "Select peak(s)")]
        [Required(ErrorMessage = "Track peak(s) is required")]
        public List<int> PeaksIds { get; set; }

        [Display(Name = "Select landmark(s)")]
        [Required(ErrorMessage = "Track landmark(s) is required")]
        public List<int> LandmarksIds { get; set; }

        [Display(Name = "Select mountain(s)")]
        [Required(ErrorMessage = "Track mountain(s) is required")]
        public List<int> MountainsIds { get; set; }

        //Mountain
        //Todo new migration and Uncomment to pass them in AddNewTrack - let's hope it works

        //public int? MountainId { get; set; }

        //public int? PeakId { get; set; }

        //public int? LandmarkId { get; set; }

    }
}
