using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wiki.Context;
using Wiki.Model;

namespace Wiki
{
    public partial class MainWindow : Window
    {
        private WikiDbContext dbContext = new();
        public MainWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            // Getting a list of countries from the database
            // Получаем список стран из базы данных
            List<Country> countries = dbContext.Country.ToList();

            // Assigning a list of countries as a data source for the ListBox
            // Присваиваем список стран в качестве источника данных для ListBox
            countryListBox.ItemsSource = countries;
        }

        private void сountryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check that the ListBox element has been selected
            // Проверяем, что был выбран элемент ListBox
            if (countryListBox.SelectedItem != null)
            {
                // Get the selected country
                // Получаем выбранную страну
                Country selectedCountry = countryListBox.SelectedItem as Country;

                // Displaying information about the selected country in TextBlock
                // Отображаем информацию о выбранной стране в TextBlock
                countryNameTextBlock.Text = $"Сountry: {selectedCountry.Name}";
                countryYearTextBlock.Text = $"Year: {selectedCountry.Year.ToString()}";
                countryBoardTextBlock.Text = $"Type of board: {selectedCountry.TypeOfBoard}";
                countryPopulationTextBlock.Text = $"Population: {selectedCountry.Population.ToString()} people";
                countryAreaTextBlock.Text = $"Area: {selectedCountry.Area.ToString()} km²";
                countryGDPTextBlock.Text = $"GDP: {selectedCountry.GDP.ToString()}";

                // Download the image from the link
                // Загружаем изображение по ссылке
                BitmapImage image = new BitmapImage(new Uri(selectedCountry.Map));

                // Setting the image to the Image element
                // Устанавливаем изображение в элемент Image
                countryMapImage.Source = image;
            }
        }
    }
}
