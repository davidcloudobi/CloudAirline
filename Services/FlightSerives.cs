using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Class;
using AirLineServices.Interface;
using CloudAirline;
using CloudAirline.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Services
{
   public class FlightSerives : IAirlineServices
    {
        // IdentityDbContext<ApplicationUser>,
        private readonly ApplicationDbContext db;

        public FlightSerives(ApplicationDbContext db)
           // : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.db = db;
        }
        public Airline GetSingleAirLine(int id)
        {
            
            
           // var user = new ApplicationUser();
           // var r = new ApplicationDbContext();
           // var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new FlightSerives()));
           // manager.Users.FirstOrDefault(x => x.Age == 5);
            


            //  user.TransactionDetails.Where()
            //using (var db = new FlightSerives())
            //{
            //    var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));


            //}

            throw new NotImplementedException();
        }

        public IEnumerable<Airline> GetAllAirline()
        {
            throw new NotImplementedException();
        }

        public Airline AddAirline(Airline newAirline)
        {
            throw new NotImplementedException();
        }

        public Airline RemoveAirline(Airline removedAirline)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public Airline UpdateAirLine(Airline airline)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Airline> FilteredAirlines(User user)
        {
            throw new NotImplementedException();
        }
    }
}
