using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Class;
using AirLineServices.Interface;

namespace AirLineServices.Services
{
    public class UserServices : IUserServices
    {

        public UserServices()
        {

        }

        public async Task<User> AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
