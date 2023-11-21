using CommonLibrary;
using Microsoft.ServiceFabric.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreImplementation : IBookStore
    {
        string InstanceId;
        IReliableStateManager StateManager;

        public BookStoreImplementation()
        {

        }

        public BookStoreImplementation(IReliableStateManager stateManager, string id)
        {
            InstanceId = id;
            StateManager = stateManager;
        }

        public async Task<bool> EnlistPurchase(string bookId, uint count)
        {
            Book ba = new Book();
            List<Book> lista = ba.getListOfLibrary();
            bool retVal = false;
            foreach (var list in lista)
            {
                if(list.BookId == bookId)
                {
                    if(list.Quantity >= count)
                    {
                        list.Quantity = list.Quantity - (int)count;
                        retVal = true;
                    }
                }
            }
            return retVal;
        }

        public async Task<double> GetItemPrice(string bookId)
        {
            double price = -1;

            Book ba = new Book();
            List<Book> lista = ba.getListOfLibrary();

            foreach (var list in lista) { 
                if (list.BookId == bookId)
                {
                    price = list.Price;
                }
            }

            return price;
        }

        public async Task<List<Book>> ListAvailableItem()
        {
            Book ba = new Book();
            List<Book> lista = ba.getListOfLibrary();
            return lista;
        }
    }
}
