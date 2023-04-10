using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;
using Shopping_Surface_WPF.Helpers;
using Shopping_Surface_WPF.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Shopping_Surface_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(new ServiceCollection()
                .AddSingleton<ISellerLogic, SellerLogic>()
                .AddSingleton<IRegisterLogic,RegisterLogic>()
                .AddSingleton<IButtonOpener,ButtonOpener>()
                .AddSingleton<IRegisterOpenerLogic,RegisterOpenerLogic>()
                .AddSingleton<IMessenger>(WeakReferenceMessenger.Default)
                .BuildServiceProvider());
        }
    }
}
