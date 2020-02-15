using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Class;
using AirLineServices.Interface;
using AirLineServices.SqlDataServices;

namespace AirLineServices.Services
{
    public class AirLineServices:IAirlineServices
    {
        private readonly SqlAirlineServices db;

        public AirLineServices(SqlAirlineServices db)
        {
            this.db = db;
        }
        public async Task<Airline> GetSingleAirLine(int id)
        {
            return await db.Airlines.FirstOrDefaultAsync(res => res.Id == id);
        }

        public async Task<IEnumerable<Airline>> GetAllAirline()
        {
            return await db.Airlines.ToListAsync();
        }

        public Airline AddAirline(Airline newAirline)
        {
            if (newAirline != null)
            {
                db.Airlines.Add(newAirline);
            }

            

            return newAirline;
        }

        public void RemoveAirline(Airline removedAirline)
        {
            if (removedAirline != null)
            {
                db.Entry(removedAirline).State = EntityState.Deleted;
            }
        }

        public async  Task<int> Commit()
        {
            return await db.SaveChangesAsync();
        }

        public async Task<Airline> UpdateAirLine(Airline airline)
        {
            var res = await db.Airlines.FirstOrDefaultAsync(val => val.Id == airline.Id);
            res.BookingAmount = airline.BookingAmount;
            res.Time = airline.Time;
            res.Destination = airline.Destination;
            res.TravelType = airline.TravelType;
            res.Name = airline.Name;
            db.Airlines.Attach(res);
            db.Entry(res).State = EntityState.Modified;

            return res;

        }

        public async Task<IEnumerable<Airline>> FilteredAirlines(User user)
        {
            return await db.Airlines.Where(res => res.Destination == user.Destination || res.TravelType == user.TravelType || res.BookingAmount == user.BookingAmount).ToListAsync();
        }
    }
}
