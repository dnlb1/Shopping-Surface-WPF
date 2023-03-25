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
        public string TaxNumber { get; set; }
        public string ContactPerson { get; set; }
        public int Rating { get; set; }
        public SellerList<Products> ProductList { get; set; }
    }
}
