using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [ServiceContract]
    public interface ITransaction
    {
        [OperationContract]
        Task<bool> Prepare();

        [OperationContract]
        Task<bool> Commit();

        [OperationContract]
        Task<bool> Rollback();
    }
}
