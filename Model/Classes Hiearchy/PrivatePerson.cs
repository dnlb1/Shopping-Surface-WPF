using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    public class PrivatePerson : ObservableObject, ISeller
    {
        public PrivatePerson(string taxNumber, string contactPerson, int rating, SellerList<Products> productList)
        {
            TaxNumber = taxNumber;
            ContactPerson = contactPerson;
            Rating = rating;
            ProductList = productList;
        }

        private string taxnumber;
        public string TaxNumber
        {
            get { return taxnumber; }
            set { SetProperty(ref taxnumber , value); }
        }
        private string contactperson;
        public string ContactPerson
        {
            get { return contactperson; }
            set { SetProperty(ref contactperson, value); }
        }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set { SetProperty(ref rating , value); }
        }

        public SellerList<Products> ProductList { get; set; }
    }
}
