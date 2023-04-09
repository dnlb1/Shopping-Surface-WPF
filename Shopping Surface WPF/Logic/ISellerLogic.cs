﻿using Model.Interface;
using Model.Product;
using System.Collections.Generic;

namespace Shopping_Surface_WPF.Logic
{
    interface ISellerLogic
    {
        void AddToRegisteredMembers(ISeller Person);
        void RegisterMember();
        void Setup(IList<ISeller> registeredMembers, IList<ISeller> searchedMembers, IList<ISeller> rewardedMembers);
        void AddToTree(Products Product);
    }
}