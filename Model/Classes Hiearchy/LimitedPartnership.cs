using Model.Product;
using Model.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes_Hiearchy
{
    public class LimitedPartnership : LegalPerson
    {
        public LimitedPartnership(string taxNumber, string contactPerson, int rating, SellerList<Products> productList) : base(taxNumber, contactPerson, rating, productList)
        {
        }
    }
}
