using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Models
{
    public class AdventureOrder
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string UserId { get; set; }


        public List<OrderItem> OrderItems { get; set; }
    }
}
