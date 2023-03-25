using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface ISeller
    {
        string TaxNumber { get; set; }
        string ContactPerson { get; set; }
        int Rating { get; set; }

    }
}
