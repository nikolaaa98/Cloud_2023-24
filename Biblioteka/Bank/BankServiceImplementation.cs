using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using Microsoft.ServiceFabric.Data;

namespace Bank
{
    public class BankServiceImplementation : IBank
    {

        string InstanceId;
        IReliableStateManager StateManager;
        
        public BankServiceImplementation()
        {

        }

        public BankServiceImplementation(IReliableStateManager stateManager, string id)
        {
            InstanceId = id;
            StateManager = stateManager;
        }

        public async Task<double> EnlistMoneyTransfer(string userID, double amount)
        {
            BankAccount ba = new BankAccount();
            List<BankAccount> lista = ba.getListOfBankAccount();
            double status = -1;
            foreach (var list in lista)
            {
                if (list.UserId == userID)
                {
                    if (list.Balance > amount)
                    {
                        list.Balance = list.Balance - amount;
                        status = list.Balance;
                    }
                }
            }

            return status;
        }

        public async Task<List<BankAccount>> ListClients()
        {
            BankAccount ba = new BankAccount();
            List<BankAccount> lista = ba.getListOfBankAccount();
            return lista;
        }
    }
}
