using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [DataContract]
    public class BankAccount
    {
        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string UserLastName { get; set; }

        [DataMember]
        public double Balance { get; set; }

        public List<BankAccount> BankAccounts = new List<BankAccount>();

        public BankAccount(string id, string name, string lastName, double balance)
        {
            UserId = id;
            UserName = name;
            UserLastName = lastName;
            Balance = balance;
            BankAccounts.Add(new BankAccount(UserId, UserName, UserLastName, Balance));
        }

        public BankAccount()
        {
            UserId = "";
            UserName = "";
            UserLastName = "";
            Balance = 0;
        }

        public List<BankAccount> getListOfBankAccount()
        {
            return BankAccounts;
        }
    }
}
