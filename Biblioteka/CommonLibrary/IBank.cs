using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [ServiceContract]
    public interface IBank
    {
        [OperationContract]
        Task<List<BankAccount>> ListClients();

        [OperationContract]
        Task<double> EnlistMoneyTransfer(string userID, double amount);
    }
}
