using Model.Interface;
using System.Collections.Generic;

namespace Shopping_Surface_WPF.Logic
{
    interface ISellerLogic
    {
        void RegisterMember();
        void Setup(IList<ISeller> registeredMembers, IList<ISeller> searchedMembers, IList<ISeller> rewardedMembers);
    }
}