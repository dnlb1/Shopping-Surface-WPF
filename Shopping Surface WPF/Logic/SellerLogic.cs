using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Surface_WPF.Logic
{
    class SellerLogic : ISellerLogic
    {
        IList<ISeller> RegisteredMembers;
        IList<ISeller> SearchedMembers;
        IList<ISeller> RewardedMembers;

        public void Setup(IList<ISeller> registeredMembers, IList<ISeller> searchedMembers, IList<ISeller> rewardedMembers)
        {
            RegisteredMembers = registeredMembers;
            SearchedMembers = searchedMembers;
            RewardedMembers = rewardedMembers;
        }
    }
}
