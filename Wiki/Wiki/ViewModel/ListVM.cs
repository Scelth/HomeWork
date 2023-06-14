using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Wiki.Context;
using Wiki.Messages;
using Wiki.Model;
using Wiki.Services.Interfaces;

namespace Wiki.ViewModel
{
    class ListVM : ViewModelBase
    {
        WikiDbContext context = new();
        private ViewModelBase selectedPage;
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;

        private List<Country> _list;
        public List<Country> List
        {
            get => _list;
            set
            {
                if (_list != value)
                {
                    Set(ref _list, value);
                }
            }
        }

        private Country _selectedCountry;
        public Country SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                if (_selectedCountry != value)
                {
                    _selectedCountry = value;
                    RaisePropertyChanged(nameof(SelectedCountry));
                }
            }
        }

        public ListVM(IMessenger messenger, INavigateService navigateService)
        {
            _messenger = messenger;
            _navigateService = navigateService;

            //_messenger.Register<DataMessage>(this, message =>
            //{
            //    country = message.Data as Country;
            //});

            List<Country> countries = context.Country.ToList();
            List = countries;
        }

        //public RelayCommand InfoCommand
        //{
        //    get => new(() =>
        //    {
        //        _navigateService.NavigateTo<InfoVM>();
        //    });
        //}
    }
}
