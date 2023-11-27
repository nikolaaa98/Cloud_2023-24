using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;

namespace CommonLibrary
{
    [ServiceContract]
    public interface IBank : IService
    {
        [OperationContract]
        Task<List<BankAccount>> ListClients();

        [OperationContract]
        Task<double> EnlistMoneyTransfer(string userID, double amount);
    }
}
