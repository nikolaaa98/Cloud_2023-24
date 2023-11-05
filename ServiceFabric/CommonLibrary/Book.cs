using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Book
    {
        public string Name { get; set; }
        public string ImePisca { get; set; }
        public double Cena { get; set; }
        public int GodinaProizvodnje { get; set; }

        public Book()
        {

            Name = "";
            ImePisca = "";
            Cena = 0;
            GodinaProizvodnje = 0;
        }

        public Book(string name, string ime, double c, int god)
        {
            Name = name;
            ImePisca = ime;
            Cena = c;
            GodinaProizvodnje = god;
        }
    }
}
