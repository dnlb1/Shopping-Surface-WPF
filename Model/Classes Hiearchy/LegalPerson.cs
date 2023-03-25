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
        public string TaxNumber { get; set; }
        public string ContactPerson { get; set; }
        public int Rating { get; set; }
    }
}
