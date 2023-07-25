using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using ICQ.Model;
using ICQ.Services.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICQ.Messages;
using System.IO;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace ICQ.ViewModel
{
    class MainVM : ViewModelBase
    {
        private ViewModelBase selectedPage;
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;
        
        private UserModel _user;
        public UserModel User
        {
            get => _user;
            set
            {
                Set(ref _user, value);
            }
        }

        public ViewModelBase CurrentViewModel
        {
            get => selectedPage;
            set
            {
                Set(ref selectedPage, value);
            }
        }

        public void ReceiveMessage(NavigationMessage message)
        {
            CurrentViewModel = App.Container.GetInstance(message.VMType) as ViewModelBase;
        }

        public MainVM(IMessenger messenger, INavigateService navigateService)
        {
            User = new();

            _messenger = messenger;
            _navigateService = navigateService;
            _messenger.Register<NavigationMessage>(this, ReceiveMessage);
        }

        public RelayCommand LogInCommand
        {
            get => new(() =>
            {
                if (User.Username != null)
                {
                    _navigateService.NavigateTo<ChatVM>();
                }

                else 
                {
                    MessageBox.Show("Enter your username!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            });
        }
    }
}
