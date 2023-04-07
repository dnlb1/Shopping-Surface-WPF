﻿using Model.Classes_Hiearchy;
using Model.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shopping_Surface_WPF.ViewModels.RegisterViewModels
{
    class PrivateMemberRegisterViewModel
    {
        public PrivatePerson Person { get; set; }
        public Products Product { get; set; }
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
        }
    }
}
