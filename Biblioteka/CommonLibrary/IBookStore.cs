using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [ServiceContract]
    public interface IBookStore : IService
    {
        [OperationContract]
        Task<List<Book>> ListAvailableItem();

        [OperationContract]
        Task<bool> EnlistPurchase(string bookId, uint count);

        [OperationContract]
        Task<double> GetItemPrice(string bookId);
    }
}
