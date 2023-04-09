using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Shopping_Surface_WPF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shopping_Surface_WPF.ViewModels
{
    class RegisterSurfaceViewModel : ObservableRecipient
    {
        IRegisterLogic logic;

        //Buttons
        public ICommand AddPrivate { get; set; }
        public ICommand AddLTD { get; set; }
        public ICommand AddLimited { get; set; }
        public ICommand AddLegal { get; set; }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
        public RegisterSurfaceViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<IRegisterLogic>())
        {

        }

        public RegisterSurfaceViewModel(IRegisterLogic logic)
        {
            this.logic = logic;
            AddPrivate = new RelayCommand(() =>
            {
                logic.RegisterPrivate();
            },
            () =>
            {
                return true;
            });
            AddLTD = new RelayCommand(() =>
            {
            },
            () =>
            {
                return true;
            });
            AddLimited = new RelayCommand(() =>
            {
            },
            () =>
            {
                return true;
            });
            AddLegal = new RelayCommand(() =>
            {
                logic.RegisterLegal();
            },
            () =>
            {
                return true;
            });
        }

    }
}
