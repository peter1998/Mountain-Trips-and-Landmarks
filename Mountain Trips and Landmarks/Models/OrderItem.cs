using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int Amounmt { get; set; }

        public int TrackId { get; set; }
        [ForeignKey("TrackId")]
        public virtual Track Track { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("TrackId")]
        public virtual AdventureOrder AdventureOrder { get; set; }
    }
}
