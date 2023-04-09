using Model.Interface;
using Model.Product;
using System.Collections.Generic;

namespace Shopping_Surface_WPF.Logic
{
    interface ISellerLogic
    {
        void AddToRegisteredMembers(ISeller Person);
        void AddToTree(Products Product);
        void AllProductByArticleNumber(int ArticleNumber);
        void AllProductPerson(ISeller Person);
        void RegisterMember();
        void Setup(IList<ISeller> registeredMembers, IList<Products> searchedMembers, IList<ISeller> rewardedMembers);
        void ClearList();
    }
}