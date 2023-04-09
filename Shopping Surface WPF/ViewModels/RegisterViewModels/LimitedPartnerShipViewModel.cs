using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Model.Classes_Hiearchy;
using Model.Product;
using Shopping_Surface_WPF.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shopping_Surface_WPF.ViewModels.RegisterViewModels
{
    class LimitedPartnerShipViewModel : ObservableRecipient
    {
        ISellerLogic logic;
        public LimitedPartnership Person { get; set; }
        public Products Product { get; set; }
        //Product
        private int articlenumber;
        public int ArticleNumber
        {
            get { return articlenumber; }
            set
            {
                SetProperty(ref articlenumber, value);
                (AddToPersonProduct as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        private string productname;
        public string ProductName
        {
            get { return productname; }
            set
            {
                SetProperty(ref productname, value);
                (AddToPersonProduct as RelayCommand).NotifyCanExecuteChanged();
            }
        }
        //Person
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
                (AddToList as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        private string taxnumber;

        public string Taxnumber
        {
            get { return taxnumber; }
            set
            {
                SetProperty(ref taxnumber, value);
                (AddToList as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        private int rating;

        public int Rating
        {
            get { return rating; }
            set
            {
                SetProperty(ref rating, value);
                (AddToList as RelayCommand).NotifyCanExecuteChanged();
            }
        }



        public ObservableCollection<Label> Added { get; set; }
        public ICommand AddToPersonProduct { get; set; }
        public ICommand AddToList { get; set; }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
        public LimitedPartnerShipViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<ISellerLogic>())
        {

        }
        public LimitedPartnerShipViewModel(ISellerLogic logic)
        {
            this.logic = logic;
            this.Person = new LimitedPartnership();
            this.Product = new Products();

            AddToPersonProduct = new RelayCommand(() =>
            {
                //Maybe need logic, but its faster 
                Product.ProductName = ProductName;
                Product.ArticleNumber = ArticleNumber;
                Person.ProductList.Add(Product);
                logic.AddToTree(Product);
                (AddToList as RelayCommand).NotifyCanExecuteChanged();

            }, () => { return (ProductName != "" && ProductName != null) && ArticleNumber != 0; });
            AddToList = new RelayCommand(() =>
            {
                Person.TaxNumber = Taxnumber;
                Person.Rating = Rating;
                Person.ContactPerson = Name;
                logic.AddToRegisteredMembers(Person);
            },
            () =>
            {
                return (Taxnumber != " " && Taxnumber != null) && (Name != " " && Name != null) && Person.ProductList.Count() != 0;
            });
        }
    }
}
