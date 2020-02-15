using System.Collections.Generic;
using System.Threading.Tasks;
using AirLine.Modules.Class;

namespace AirLineServices.Interface
{
    public interface IUserServices
    {
        Task<User> AddUser(User newUser);
        Task<User> UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<int> Commit();
        Task<User> GetUser(int id);

    }
}