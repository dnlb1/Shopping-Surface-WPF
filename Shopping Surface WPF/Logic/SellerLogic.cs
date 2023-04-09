using Model.Interface;
using Model.Product;
using Model.Structures;
using Shopping_Surface_WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Surface_WPF.Logic
{
    class SellerLogic : ISellerLogic
    {
        IRegisterOpenerLogic Register;

        IList<ISeller> RegisteredMembers;
        IList<ISeller> SearchedMembers;
        IList<ISeller> RewardedMembers;

        BinaryTree<Products, string, int> Tree;
        public SellerLogic(IRegisterOpenerLogic Register)
        {
            this.Register = Register;
            this.Tree = new BinaryTree<Products, string, int>();
        }

        public void Setup(IList<ISeller> registeredMembers, IList<ISeller> searchedMembers, IList<ISeller> rewardedMembers)
        {
            RegisteredMembers = registeredMembers;
            SearchedMembers = searchedMembers;
            RewardedMembers = rewardedMembers;
        }
        public void RegisterMember()
        {
            Register.OpenRegisterSurface();
        }
        public void AddToRegisteredMembers(ISeller Person)
        {
            RegisteredMembers.Add(Person);
        }
        public void AddToTree(Products Product)
        {
            Tree.Add(Product, Product.ArticleNumber, Product.ProductName);
        }
    }
}
