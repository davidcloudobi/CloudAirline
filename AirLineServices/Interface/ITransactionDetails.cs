using System.Collections.Generic;
using System.Threading.Tasks;
using AirLine.Modules.Class;

namespace AirLineServices.Interface
{
    public interface ITransactionDetails
    {
        void Add(User user);
        Task<IEnumerable<TransactionDetails>> GetAll();
        Task<IEnumerable<TransactionDetails>> GetSingleUser(User user);

    }
}