using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class Mountain
    {
        [Key]
        public int MountainId { get; set; }

        public string MountainPictureURL { get; set; }

        public string Name { get; set; }

        public int TrekkingTime { get; set; }

        public string Description { get; set; }
    }
}
