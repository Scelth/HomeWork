using GalaSoft.MvvmLight;

namespace ICQ.Services.Inerfaces
{
    interface INavigateService
    {
        public void NavigateTo<T>(object? data = null) where T : ViewModelBase;
    }
}
