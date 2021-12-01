using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Landmarks_Mountains
    {
        public int LandmarkId { get; set; }

        public Landmark Landmark { get; set; }

        public int MountainId { get; set; }

        public Mountain  Mountain { get; set; }
    }
}
