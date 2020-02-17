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
    public class UserServices : IUserServices
    {
        private readonly SqlAirlineServices db;

        public UserServices(SqlAirlineServices db)
        {
            this.db = db;
        }

        public User AddUser(User newUser)
        {
            // throw new NotImplementedException();

            if (newUser != null)
            {
                db.Users.Add(newUser);
            }

            return newUser;
        }

        public async Task<User> UpdateUser(User user)
        {
            //throw new NotImplementedException();
            if (user != null)
            {
                var updateUser = await db.Users.FirstOrDefaultAsync(res => res.Id == user.Id);
                if (updateUser != null)
                {
                    updateUser.Age = user.Age;
                    updateUser.Address = user.Address;
                    updateUser.BookingAmount = user.BookingAmount;
                    updateUser.Destination = user.Destination;
                    updateUser.PassportId = user.PassportId;
                    updateUser.Time = user.Time;
                    updateUser.TravelType = user.TravelType;
                    updateUser.Name = user.Name;
                    db.Users.Attach(updateUser);
                    db.Entry(updateUser).State = EntityState.Modified;


                }
                return updateUser;
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            //throw new NotImplementedException();

            return await db.Users.ToListAsync();
        }

        public async Task<int> Commit()
        {
            //throw new NotImplementedException();
            return await db.SaveChangesAsync();
        }

        public async Task<User> GetUser(int id)
        {
            // throw new NotImplementedException();
            var notFound = new User();
            var user = await db.Users.FirstOrDefaultAsync(res => res.Id == id);

            if (user == null)
            {

                return notFound;
            }
            return user;

        }
    }
}
