using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using MVVM.Model.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model.Services
{
    internal class Navigation : INavigateService
    {
        private readonly IMessenger _messenger;

        public Navigation(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void NavigateTo<T>() where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage()
            {
                VMType = typeof(T)
            });
        }
    }
}