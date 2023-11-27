using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    [DataContract]
    public class FormModel
    {
        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string UserLastName { get; set; }

        [DataMember]
        public double Balance { get; set; }

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

        public FormModel(string userID1, string UserName1, string UserLastName1, double Balance1, string bookId1, double Price1, string Name1, string wName1, int quant1)
        {
            UserId = userID1;
            UserName = UserName1;
            UserLastName = UserLastName1;
            Balance = Balance1;
            BookId = bookId1;
            Price = Price1;
            Name = Name1;
            WritterName = wName1;
            Quantity = quant1;
        }
            
        public FormModel()
        {
            UserId = "";
            UserName = "";
            UserLastName = "";
            Balance = 0;
            BookId = "";
            Price = 0;
            Name = "";
            WritterName = "";
            Quantity = 0;
        }
    }
}
