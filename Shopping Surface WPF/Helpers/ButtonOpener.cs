using Shopping_Surface_WPF.ButtonWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Surface_WPF.Helpers
{
    class ButtonOpener : IButtonOpener
    {
        public void SearchByArticle()
        {
            new SearchByNumberWindow().ShowDialog();
        }
        public void SearchByName()
        {
            new SearchByNameWindow().ShowDialog();
        }
    }
}
