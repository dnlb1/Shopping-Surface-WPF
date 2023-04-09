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

namespace Shopping_Surface_WPF.ViewModels.ButtonViewModels
{
    class SearchByNumberWindowViewModel : ObservableRecipient
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

        private int articlenumber;

        public int ArticleNumber
        {
            get { return articlenumber; }
            set 
            { 
                SetProperty(ref articlenumber, value);
                (Search as RelayCommand).NotifyCanExecuteChanged();
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                SetProperty(ref name , value);
                (SearchByName as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        public ICommand SearchByName { get; set; }
        public ICommand Search { get; set; }

        public SearchByNumberWindowViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<ISellerLogic>())
        {

        }
        public SearchByNumberWindowViewModel(ISellerLogic logic)
        {
            this.logic = logic;
            Search = new RelayCommand(() =>
            {
                logic.AllProductByArticleNumber(ArticleNumber);
            },
            () =>
            { return ArticleNumber > 0; });
            SearchByName = new RelayCommand(() =>
            {
                logic.AllProductByName(Name);
            },
            () =>
            { return Name != "" && Name != null; });
        }
    }
}
