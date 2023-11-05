using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class BookServiceImplementation : IBooks
    {
        public bool WriteAllBooks(Book k)
        {
            if (k.Name != "Nikola")
                return true;
            else
                return false;
        }
    }
}
