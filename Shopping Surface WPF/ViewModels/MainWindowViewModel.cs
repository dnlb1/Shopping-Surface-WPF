using Microsoft.Toolkit.Mvvm.ComponentModel;
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



    }
}
