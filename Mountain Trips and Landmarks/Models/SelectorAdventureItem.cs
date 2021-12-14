using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class SelectorAdventureItem
    {
        [Key]
        public int Id { get; set; }

        public Track Track { get; set; }
        public string PeakName { get; set; }

        public string LandmarkName { get; set; }

        

        public int Targets { get; set; }

        public string SelectorAdventureId { get; set; }
    }
}
