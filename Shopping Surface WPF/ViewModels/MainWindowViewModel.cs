using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Model.Interface;
using Model.Product;
using Shopping_Surface_WPF.Helpers;
using Shopping_Surface_WPF.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shopping_Surface_WPF.ViewModels
{
    class MainWindowViewModel : ObservableRecipient
    {
        //Logic 
        ISellerLogic logic;
        IButtonOpener opener;
        //3 List
        public ObservableCollection<ISeller> RegisteredMembers { get; set; }
        public ObservableCollection<Products> SearchedMembers { get; set; }
        public ObservableCollection<ISeller> RewardedMembers { get; set; }

        //Selected Items
        private ISeller registeredselected;
        public ISeller RegisteredSelected
        {
            get { return registeredselected; }
            set 
            { 
                SetProperty(ref registeredselected , value);
                (AllProduct as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        //Buttons - Command
        public ICommand Register { get; set; }
        public ICommand AllProduct { get; set; }
        public ICommand ItemNumberSearch { get; set; }
        public ICommand NameSearch { get; set; }
        public ICommand RewardMember { get; set; }
        public ICommand Clear { get; set; }

        //Other
        private Visibility vis;

        public Visibility Vis
        {
            get { return vis; }
            set 
            { 
                SetProperty(ref vis, value);
                (Register as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<ISellerLogic>(), Ioc.Default.GetService<IButtonOpener>()) 
        {

        }

        public MainWindowViewModel(ISellerLogic logic, IButtonOpener opener)
        {
            this.logic = logic;
            this.opener = opener;
            RegisteredMembers = new ObservableCollection<ISeller>();
            SearchedMembers = new ObservableCollection<Products>();
            RewardedMembers = new ObservableCollection<ISeller>();

            logic.Setup(RegisteredMembers, SearchedMembers, RewardedMembers);

            Register = new RelayCommand(() =>
            {
                Vis = Visibility.Hidden;
                logic.RegisterMember();
                Vis = Visibility.Visible;
            },
            () =>
            {
                return true;
            });

            AllProduct = new RelayCommand(() =>
            {
                logic.AllProductPerson(RegisteredSelected);
            },
           () =>
           {
               return RegisteredSelected != null;
           });

            ItemNumberSearch = new RelayCommand(() =>
            {
                opener.SearchByArticle();
            },
            () =>
            {
                return true;
            });

            NameSearch = new RelayCommand(() =>
            {
                opener.SearchByName();
            },
            () =>
            {
                return true;
            });

            RewardMember = new RelayCommand(() =>
            {

            },
            () =>
            {
                return true;
            });

            Clear = new RelayCommand(() =>
            {
                logic.ClearList();
            },
            () =>
            {
                return true;
            });

        }

    }
}
