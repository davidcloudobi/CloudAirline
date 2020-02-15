using AirLine.Modules.Class;
using AirLineServices.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudAirline;
using CloudAirline.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Services
{
    //public class Customer : IdentityDbContext<ApplicationUser>, IUserServices
    // {
    //    // private readonly ApplicationUserManager userManager;
    //    public User _user;

    //     public Customer()
    //         : base("DefaultConnection", throwIfV1Schema: false)
    //     {
    //        // this.userManager = userManager;
    //     }
    //     public async Task<User> AddUser(User newUser)
    //     {
    //        // userManager.Users.FirstOrDefault(x => x.Age == 5);
    //         var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
    //        // var user2 = await manager.CreateAsync();
    //         var user = await manager.Users.FirstOrDefaultAsync(x => x.Age == 3);

    //        newUser.Age = user.Age;
    //        newUser.Address = user.Address;
    //        newUser.BookingAmount = user.BookingAmount;
    //        newUser.Name = user.Name;
    //        newUser.Time = user.Time;
    //        newUser.PassportId = user.PassportId;
    //        newUser.Id = Convert.ToInt32(user.Id);
    //        newUser.TravelType = user.TravelType;
    //        return newUser;
    //     }

    //     public User UpdateUser(User user)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public IEnumerable<User> GetAllUsers()
    //     {
    //         throw new NotImplementedException();
    //     }


    //     public int Commit()
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public async Task<User> GetUser(int id)
    //     {

    //         var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
    //         var user = await manager.Users.FirstOrDefaultAsync(x => x.Age == id);
    //         _user.Age = user.Age;
    //         _user.Address = user.Address;
    //         _user.BookingAmount = user.BookingAmount;
    //         _user.Name = user.Name;
    //         _user.Time = user.Time;
    //         _user.PassportId = user.PassportId;
    //         _user.Id = Convert.ToInt32(user.Id);
    //         _user.TravelType = user.TravelType;

    //         return _user;
    //     }

    // }



    //############################################################################################
    //###############################################################################################

    public class Customer : IdentityDbContext<ApplicationUser>, ICustomer
    {
       
     

        public Customer()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }
        public async Task<ApplicationUser> AddUser(ApplicationUser newUser)
        {
       
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
             var user2 = await manager.CreateAsync(newUser);

             return newUser;
        }

        public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
            var updatedUser = await manager.Users.FirstOrDefaultAsync(x => x.Id == user.Id);

            if (updatedUser != null)
            {
                updatedUser.Age = user.Age;
                updatedUser.Address = user.Address;
                updatedUser.BookingAmount = user.BookingAmount;
                updatedUser.Name = user.Name;
                updatedUser.Time = user.Time;
                updatedUser.PassportId = user.PassportId;
                updatedUser.TravelType = user.TravelType;

                return updatedUser;
            }

            return user;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
             var res = await manager.Users.ToListAsync();
             return res;
        }


        public async Task<int> Commit()
        {
            return await SaveChangesAsync();
        }

        public async Task<ApplicationUser> GetUser(int id)
        {

            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new Customer()));
            var user = await manager.Users.FirstOrDefaultAsync(x => x.Age == id);
            return user;
        }

    }

}
