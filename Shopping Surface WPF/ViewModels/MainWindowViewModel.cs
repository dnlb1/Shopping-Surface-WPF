using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Model.Interface;
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

        //3 List
        public ObservableCollection<ISeller> RegisteredMembers { get; set; }
        public ObservableCollection<ISeller> SearchedMembers { get; set; }
        public ObservableCollection<ISeller> RewardedMembers { get; set; }

        //Selected Items
        public ISeller RegisteredSelected { get; set; }
        public ISeller SearchedSelected { get; set; }
        public ISeller RewardedSelected { get; set; }

        //Buttons - Command
        public ICommand Register { get; set; }
        public ICommand AllProduct { get; set; }
        public ICommand ItemNumberSearch { get; set; }
        public ICommand NameSearch { get; set; }
        public ICommand RewardMember { get; set; }
        
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            RegisteredMembers = new ObservableCollection<ISeller>();
            SearchedMembers = new ObservableCollection<ISeller>();
            RewardedMembers = new ObservableCollection<ISeller>();

            Register = new RelayCommand(() =>
            {

            },
            () =>
            {
                return true;
            });

            AllProduct = new RelayCommand(() =>
            {

            },
           () =>
           {
               return true;
           });

            ItemNumberSearch = new RelayCommand(() =>
            {

            },
            () =>
            {
                return true;
            });

            NameSearch = new RelayCommand(() =>
            {

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

        }

    }
}
