using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Landmarks = new List<Landmark>();
            Peaks = new List<Peak>();
            Mountains = new List<Mountain>();
        }

        public List<Landmark> Landmarks { get; set; }
        public List<Peak> Peaks { get; set; }
        public List<Mountain> Mountains { get; set; }
    }
}
