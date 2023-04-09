﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Model.Interface;
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

        public MainWindowViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<ISellerLogic>()) 
        {

        }

        public MainWindowViewModel(ISellerLogic logic)
        {
            this.logic = logic;
            RegisteredMembers = new ObservableCollection<ISeller>();
            SearchedMembers = new ObservableCollection<ISeller>();
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

            },
           () =>
           {
               return SearchedSelected !=null;
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
