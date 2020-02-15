using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Class;

namespace AirLineServices.SqlDataServices
{
  public  class SqlAirlineServices:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<TransactionDetails> TransactionActivities { get; set; }

    }
}
