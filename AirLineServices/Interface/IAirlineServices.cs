using System.Collections.Generic;
using System.Threading.Tasks;
using AirLine.Modules.Class;

namespace AirLineServices.Interface
{
    public interface IAirlineServices
    {
        Task<Airline> GetSingleAirLine(int id);
        Task<IEnumerable<Airline>> GetAllAirline();
        Airline AddAirline(Airline newAirline);
        void RemoveAirline(Airline removedAirline);
        Task<int> Commit();
        Task<Airline> UpdateAirLine(Airline airline);

      Task<IEnumerable<Airline>> FilteredAirlines(User user);

    }
}