using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Surface_WPF.Helpers
{
    class RegisterOpenerLogic : IRegisterOpenerLogic
    {
        public void OpenRegisterSurface()
        {
            RegisterSurfaceWindow W = new RegisterSurfaceWindow();
            W.ShowDialog();
        }
    }
}
