using GalaSoft.MvvmLight.Messaging;
using ICQ.Services.Classes;
using ICQ.Services.Inerfaces;
using ICQ.View;
using ICQ.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ICQ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            MainStartup();
        }

        private void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigateService, NavigateService>();

            Container.RegisterSingleton<MainVM>();
            Container.RegisterSingleton<ChatVM>();
        }

        private void MainStartup()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = Container.GetInstance<MainVM>();
            mainWindow.ShowDialog();
        }
    }
}
