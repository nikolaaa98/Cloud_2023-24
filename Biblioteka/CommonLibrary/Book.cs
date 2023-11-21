using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string BookId { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string WritterName { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public List<Book> Library = new List<Book>();


        public Book(string id, double cena, string ime, string pisac, int quantity)
        {
            BookId = id;
            Price = cena;
            Name = ime;
            WritterName = pisac;
            Quantity = quantity;
            Library.Add(new Book(BookId, Price, Name, WritterName, quantity));
        }

        public Book()
        {
            BookId = "";
            Price = 0;
            Name = "";
            WritterName = "";
            Quantity = 0;
        }

        public List<Book> getListOfLibrary()
        {
            return Library;
        }

    }
}
