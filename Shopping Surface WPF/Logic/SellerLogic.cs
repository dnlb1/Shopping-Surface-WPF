using Model.Interface;
using Model.Product;
using Model.Structures;
using Shopping_Surface_WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Shopping_Surface_WPF.Logic
{
    class SellerLogic : ISellerLogic
    {
        IRegisterOpenerLogic Register;

        IList<ISeller> RegisteredMembers;
        IList<Products> SearchedMembers;
        IList<ISeller> RewardedMembers;
        DispatcherTimer AI;

        BinaryTree<Products, string, int> Tree;
        public SellerLogic(IRegisterOpenerLogic Register)
        {
            this.Register = Register;
            this.Tree = new BinaryTree<Products, string, int>();
            this.AI = new DispatcherTimer();
            AI.Interval = new TimeSpan(10000);
            AI.Tick += AI_Tick;
        }

        public void ClearList()
        {
            SearchedMembers.Clear();
        }
        public void Setup(IList<ISeller> registeredMembers, IList<Products> searchedMembers, IList<ISeller> rewardedMembers)
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
        public void AllProductPerson(ISeller Person)
        {
            SearchedMembers.Clear();
            foreach (var item in Person.ProductList)
            {
                SearchedMembers.Add((Products)item);
            }
        }
        public void AllProductByArticleNumber(int ArticleNumber)
        {
            SearchedMembers.Clear();
            SearchedMembers.Add(Tree.ArticleNumberSearch(ArticleNumber));
        }
        public void AllProductByName(string Name)
        {
            SearchedMembers.Clear();
            foreach (var item in Tree.SearchByName(Name))
            {
                SearchedMembers.Add(item);
            }
            ;
        }

        //Rewarding - with Ai
        private void RewardMembers()
        {
            //Logic for rewarding
        }
        public void StartRewarding()
        {
            AI.Start();
        }

        private void AI_Tick(object sender, EventArgs e)
        {
            RewardMembers();
        }

        public void StopRewarding()
        {
            AI.Stop();
        }
    }
}
