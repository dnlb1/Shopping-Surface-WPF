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

namespace Shopping_Surface_WPF.ViewModels
{
    class MainWindowViewModel : ObservableRecipient
    {
        //3 List
        public ObservableCollection<ISeller> RegisteredMembers { get; set; }
        public ObservableCollection<ISeller> SearchedMembers { get; set; }
        public ObservableCollection<ISeller> RewardedMembers { get; set; }


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
