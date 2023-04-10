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
        IList<Products> Gifted;
        DispatcherTimer AI;
        Random r = new Random();
        public List<Products> Gifts { get; set; }

        BinaryTree<Products, string, int> Tree;
        public SellerLogic(IRegisterOpenerLogic Register)
        {
            this.Register = Register;
            this.Tree = new BinaryTree<Products, string, int>();
            this.AI = new DispatcherTimer();
            this.Gifts = new List<Products>();
            AI.Interval = new TimeSpan(10000);
            AI.Tick += AI_Tick;
        }

        public void ClearList()
        {
            SearchedMembers.Clear();
        }
        public void Setup(IList<ISeller> registeredMembers, IList<Products> searchedMembers, IList<ISeller> rewardedMembers, IList<Products> gifted)
        {
            RegisteredMembers = registeredMembers;
            SearchedMembers = searchedMembers;
            RewardedMembers = rewardedMembers;
            Gifted = gifted;
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
            int counter = 0; 
            foreach (var item in RegisteredMembers)
            {
                counter += item.ProductList.Count();
            }
            double avg = counter / RegisteredMembers.Count();

            foreach (var item in RegisteredMembers)
            {
                if (Gifts.Count > 0)
                {
                    //We can give them gift by rating
                    for (int i = 0; i < item.Rating && Gifts.Count>0; i++)
                    {
                        int idx = r.Next(0, Gifts.Count());
                        item.ProductList.ArrangedAdd(Gifts[idx]);
                        RewardedMembers.Add(item);
                        Gifted.Add(Gifts[idx]);
                        Gifts.Remove(Gifts[idx]);
                    }
                }
            }
            
        }
        public void StartRewarding()
        {
            //Random
            for (int i = 0; i < r.Next(0,10); i++)
            {
                string artc = "";
                for (int j = 0; j < r.Next(1,3); j++)
                {
                    artc += r.Next(1,10);
                }
                string[] names = { "Szék", "Asztal", "Hagymahámozó", "Ásványvíz", "Tolószekér", "Monitor", "Csúzli" };
                this.Gifts.Add(new Products()
                {
                    ArticleNumber = int.Parse(artc),
                    ProductName = names[r.Next(0, names.Length)]
                });
            }
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
