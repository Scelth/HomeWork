using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using ICQ.Messages;
using ICQ.Services.Inerfaces;

namespace ICQ.Services.Classes
{
    internal class NavigateService : INavigateService
    {
        private readonly IMessenger _messenger;

        public NavigateService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void NavigateTo<T>(object? data = null) where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage()
            {
                VMType = typeof(T)
            });

            if (data != null)
            {
                _messenger.Send(new DataMessage()
                {
                    Data = data
                });
            }
        }
    }
}
