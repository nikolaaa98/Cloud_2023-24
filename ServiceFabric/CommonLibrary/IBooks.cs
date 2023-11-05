using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CommonLibrary
{
    [ServiceContract]
    public interface IBooks
    {
        [OperationContract]
        bool WriteAllBooks(Book k);
    }
}
