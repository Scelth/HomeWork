using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using SimpleInjector;
using System.Windows.Navigation;
using MVVM.ViewModel;
using MVVM;
using MVVM.View;
using MVVM.Model.Services;

namespace MVVM
{
    public partial class App : Application
    {
        public static Container container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            MainStartup();
            base.OnStartup(e);
        }

        private void Register()
        {
            container.RegisterSingleton<IMessenger, Messenger>();
            container.RegisterSingleton<INavigateService, Navigation>();

            container.RegisterSingleton<MainWindowVM>();
            container.RegisterSingleton<FirstPageVM>();
            container.RegisterSingleton<SecondPageVM>();
            container.RegisterSingleton<ThirdPageVM>();
        }

        private void MainStartup()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = container.GetInstance<MainWindowVM>();
            mainWindow.ShowDialog();
        }
    }
}
