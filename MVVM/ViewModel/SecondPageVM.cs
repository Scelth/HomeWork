using GalaSoft.MvvmLight;
using MVVM.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    internal class SecondPageVM : ViewModelBase
    {
        private readonly INavigateService _navigationService;
        public SecondPageVM(INavigateService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
