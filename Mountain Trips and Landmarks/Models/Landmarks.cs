using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Landmarks
    {
        [Key]
        public int LandmarksId { get; set; }

        public string LandmarkPictureURL { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }
    }
}
