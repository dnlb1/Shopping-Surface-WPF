using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Model.Classes_Hiearchy;
using Model.Product;
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
    class PrivateMemberRegisterViewModel : ObservableRecipient
    {
        public PrivatePerson Person { get; set; }
        public Products Product { get; set; }

        private int articlenumber;

        public int ArticleNumber
        {
            get { return articlenumber; }
            set 
            {
                SetProperty(ref articlenumber , value);
                (AddToPersonProduct as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        private string productname;

        public string ProductName
        {
            get { return productname; }
            set 
            {
                SetProperty(ref productname , value);
                (AddToPersonProduct as RelayCommand).NotifyCanExecuteChanged();
            }
        }



        public ObservableCollection<Label> Added { get; set; }
        public ICommand AddToPersonProduct { get; set; }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }


        public PrivateMemberRegisterViewModel()
        {
            this.Person = new PrivatePerson();
            this.Product = new Products();

            AddToPersonProduct = new RelayCommand(() => 
            { 
                Product.ProductName = ProductName;
                Product.ArticleNumber = ArticleNumber;
                Person.ProductList.Add(Product);
            }, () => { return (ProductName != "" && ProductName != null) && ArticleNumber!=0; });
            
        }
    }
}
