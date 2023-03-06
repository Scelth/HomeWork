using GalaSoft.MvvmLight;
using MVVM.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    internal class ThirdPageVM : ViewModelBase
    {
        private readonly INavigateService _navigationService;
        public ThirdPageVM(INavigateService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}