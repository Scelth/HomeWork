using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM.Model;
using MVVM.Model.Messages;
using MVVM.Model.Services;


namespace MVVM.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        private ViewModelBase selectedPage;
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;

        public MainWindowVM(IMessenger messenger, INavigateService navigateService)
        {
            _messenger = messenger;
            _messenger.Register<NavigationMessage>(this, ReceiveMessage);
            _navigateService = navigateService;
        }

        public ViewModelBase SelectedPage
        {
            get 
            { 
                return selectedPage; 
            }

            set
            {
                if (selectedPage != value)
                {
                    Set(ref selectedPage, value);
                }
            }
        }

        public RelayCommand FirstButtonCommand
        {
            get => new(() =>
            {
                _navigateService.NavigateTo<FirstPageVM>();
            });
        }

        public RelayCommand SecondButtonCommand
        {
            get => new(() =>
            {
                _navigateService.NavigateTo<SecondPageVM>();
            });
        }

        public RelayCommand ThirdButtonCommand
        {
            get => new(() =>
            {
                _navigateService.NavigateTo<ThirdPageVM>();
            });
        }

        public void ReceiveMessage(NavigationMessage message)
        {
            SelectedPage = App.container.GetInstance(message.VMType) as ViewModelBase;
        }
    }
}