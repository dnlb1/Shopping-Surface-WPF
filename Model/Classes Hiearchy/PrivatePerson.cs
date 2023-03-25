using Model.Interface;
using Model.Product;
using Model.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes_Hiearchy
{
    public class PrivatePerson : ISeller
    {
        public PrivatePerson(string taxNumber, string contactPerson, int rating, SellerList<Products> productList)
        {
            TaxNumber = taxNumber;
            ContactPerson = contactPerson;
            Rating = rating;
            ProductList = productList;
        }

        public string TaxNumber { get; set; }
        public string ContactPerson { get; set; }
        public int Rating { get; set; }
        public SellerList<Products> ProductList { get; set; }
    }
}
