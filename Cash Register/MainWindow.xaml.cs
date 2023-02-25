using Cash_Register.Services.Classes.Gas;
using Cash_Register.Services.Classes.Menu;
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
        private IGasPrice gasPrice = new GasPrice();
        private LiterOrCash literOrCash = new();
        private GetMarkPrice gas_price = new();
        private Order order = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            double payment = double.Parse(cafePaymentTextBlock.Text) + double.Parse(gasPaymentTextBlock.Text);
            Sum.Text = payment.ToString("0.00") + " $";
        }

        private void gasComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gasPrice.Price(gasComboBox, A_92, A_95, A_98, priceTextBlock, gas_price);
        }

        private void gasRadioButton_Click(object sender, RoutedEventArgs e)
        {
            literOrCash.Pay((RadioButton)sender, litersTextBox, cashTextBox, gasPaymentTextBlock, gas_price);
        }

        private void cafeCheckBox_Click(object sender, RoutedEventArgs e)
        {
            order.Pay((CheckBox)sender, hod_dogTextBox, hamburgerTextBox, friesTextBox, colaTextBox);
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            cafePaymentTextBlock.Text = order.Pay();
        }
    }
}