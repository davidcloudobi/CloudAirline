using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AirLine.Modules.Enums;

namespace AirLine.Modules.Class
{
    public class Airline
    {
      public  int Id { get; set; }
      [Required]
      [MaxLength(225)]
      public  string Name { get; set; }
      public  decimal BookingAmount { get; set; }
      [Required]

        public  TravelClass TravelType { get; set; }
        [Required]
        public  TraveTime Time { get; set; }
        [Required]
        public string Destination { get; set; }




    }

}