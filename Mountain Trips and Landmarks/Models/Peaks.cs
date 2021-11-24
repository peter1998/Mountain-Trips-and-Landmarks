using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Peaks
    {
        [Key]
        public int PeakId { get; set; }
        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
