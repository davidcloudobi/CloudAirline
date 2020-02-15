using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AirLine.Modules.Enums;

namespace AirLine.Modules.Class
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(225)]
        public string Name { get; set; }
         [Required]
      [MaxLength(225)]
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]

        public int PassportId { get; set; }
        [Required]

        public decimal BookingAmount { get; set; }
        [Required]

        public TravelClass TravelType { get; set; }
        [Required]
        public TraveTime Time { get; set; }

        public string Destination { get; set; }


        
    }
}