using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Enums;

namespace AirLine.Modules.Class
{
   public class TransactionDetails
    {
        public int Id { get; set; }
        public User Person { get; set; }

        public bool PaymentStatus { get; set; }
        

       
    }
}
