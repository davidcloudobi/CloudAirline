using System.Collections.Generic;
using System.Threading.Tasks;
using CloudAirline.Models;

namespace Services
{
    public interface ICustomer
    {
        Task<ApplicationUser> AddUser(ApplicationUser newUser);
        Task<ApplicationUser> UpdateUser(ApplicationUser user);
        Task<IEnumerable<ApplicationUser>> GetAllUsers();
        Task<int> Commit();
        Task<ApplicationUser> GetUser(int id);

    }
}