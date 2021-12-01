using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Peaks_Mountains
    {

        public int PeakId { get; set; }

        public Peak Peak { get; set; }

        public int MountainId { get; set; }

        public Mountain Mountain { get; set; }

    }
}
