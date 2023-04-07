using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Shopping_Surface_WPF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shopping_Surface_WPF.ViewModels
{
    class RegisterSurfaceViewModel : ObservableRecipient
    {
        ISellerLogic logic;
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
        public RegisterSurfaceViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<ISellerLogic>())
        {

        }

        public RegisterSurfaceViewModel(ISellerLogic logic)
        {
            this.logic = logic;
        }

    }
}
