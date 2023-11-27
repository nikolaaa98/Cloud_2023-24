using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace Validator
{
    public class ValidatorImplementation : IValidator
    {
        public async Task<bool> Validate(FormModel model)
        {
            if(model == null)
            {
                return false;
            }

            if (model.UserId == "" || model.UserName == "" || model.UserLastName == "" || model.Balance < 0 || model.BookId == "" || model.Price < 0 || model.Name == "" || model.WritterName == "" || model.Quantity < 0)
            {
                return false;
            }

            try
            {
                var proxy = ServiceProxy.Create<ITransaction>(new Uri("fabric:/Biblioteka/TransactionConroller"), new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(1));
                return await proxy.Rollback();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
