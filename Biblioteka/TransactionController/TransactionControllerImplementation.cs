using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using Microsoft.ServiceFabric.Data;

namespace TransactionController
{
    public class TransactionControllerImplementation : CommonLibrary.ITransaction
    {
        string InstanceId;
        IReliableStateManager StateManager;

        public TransactionControllerImplementation()
        {

        }

        public TransactionControllerImplementation(IReliableStateManager stateManager, string id)
        {
            InstanceId = id;
            StateManager = stateManager;
        }

        public  Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public  Task<bool> Prepare()
        {
            throw new NotImplementedException();
        }

        public  Task<bool> Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
