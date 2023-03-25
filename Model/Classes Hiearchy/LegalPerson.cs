using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes_Hiearchy
{
    public class LegalPerson : ISeller
    {
        public string TaxNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactPerson { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Rating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
