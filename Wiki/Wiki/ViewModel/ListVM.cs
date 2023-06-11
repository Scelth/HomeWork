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
        //public Country country { get; set; } = new();

        //private Country _country = new();
        //public Country Country
        //{
        //    get => _country;

        //    set
        //    {
        //        if (_country != value)
        //        {
        //            Set(ref _country, value);
        //        }
        //    }
        //}

        //public ViewModelBase CurrentViewModel
        //{
        //    get => selectedPage;
        //    set
        //    {
        //        Set(ref selectedPage, value);
        //    }
        //}

        //        private ViewModelBase _info;
        //public ViewModelBase Info
        //{
        //    get => _info;
        //    set
        //    {
        //        Set(ref _info, value);
        //    }
        //}

        //public void ReceiveMessage(NavigationMessage message)
        //{
        //    CurrentViewModel = App.Container.GetInstance(message.VMType) as ViewModelBase;
        //}

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
                    //ShowCountryDetails();
                }
            }
        }

        //private void ShowCountryDetails()
        //{
        //    if (SelectedCountry != null)
        //    {
        //        string CountryName = $"Сountry: {SelectedCountry.Name}";
        //        string CountryYear = $"Year: {SelectedCountry.Year.ToString()}";
        //        string CountryBoard = $"Type of board: {SelectedCountry.TypeOfBoard}";
        //        string CountryPopulation = $"Population: {SelectedCountry.Population.ToString()} people";
        //        string countryArea = $"Area: {SelectedCountry.Area.ToString()} km²";
        //        string countryGDP = $"GDP: {SelectedCountry.GDP.ToString()}";

        //        // Download the image from the link
        //        // Загружаем изображение по ссылке
        //        BitmapImage image = new BitmapImage(new Uri(SelectedCountry.Map));

        //        // Setting the image to the Image element
        //        // Устанавливаем изображение в элемент Image
        //        var CountryMapImage = image;
        //    }
        //}

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
