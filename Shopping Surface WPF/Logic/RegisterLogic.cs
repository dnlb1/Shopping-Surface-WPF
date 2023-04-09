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
            new LegalMemberRegister().ShowDialog();
        }
        public void RegisterLimited()
        {
            new LimitedPartnerShipRegister().ShowDialog();
        }
        public void RegisterLTD()
        {
            new LTDMemberRegister().ShowDialog();
        }
        public void RegisterPrivate()
        {
            new PrivateMemberRegister().ShowDialog();
        }
    }
}
