using Cash_Register.Services.Classes;
using Cash_Register.Services.Interfaces;
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

namespace Cash_Register
{
    public partial class MainWindow : Window
    {
        private IPriceable gasPrice = new GasPrice();
        private LiterOrCash literOrCash;
        private MarkPrice _price = new();

        public MainWindow()
        {
            InitializeComponent();
            literOrCash = new(this);
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void gasComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gasPrice.Price(gasComboBox, A_92, A_95, A_98, priceTextBlock, _price);
        }

        private void gasButton_Click(object sender, RoutedEventArgs e)
        {
            literOrCash.Pay((RadioButton)sender, litersTextBox, cashTextBox, paymentTextBlock, _price);
        }
    }
}