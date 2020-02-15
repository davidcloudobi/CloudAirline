using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine.Modules.Class;
using AirLineServices.Interface;

namespace AirLineServices.Services
{
    class TransactionDetails: ITransactionDetails
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AirLine.Modules.Class.TransactionDetails>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AirLine.Modules.Class.TransactionDetails>> GetSingleUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
