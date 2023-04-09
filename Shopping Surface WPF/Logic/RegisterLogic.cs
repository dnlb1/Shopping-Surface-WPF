using Shopping_Surface_WPF.RegisterWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Surface_WPF.Logic
{
    class RegisterLogic : IRegisterLogic
    {
        public void RegisterLegal()
        {
            LegalMemberRegister W = new LegalMemberRegister();
            W.ShowDialog();
        }
        public void RegisterLimited()
        {

        }
        public void RegisterLTD()
        {

        }
        public void RegisterPrivate()
        {
            PrivateMemberRegister W = new PrivateMemberRegister();
            W.ShowDialog();
        }
    }
}
