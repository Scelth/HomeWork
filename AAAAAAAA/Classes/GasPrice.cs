using Cash_Register.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register
{
    internal class GasPrice : IPriceable
    {
        public void Price(ComboBox gasComboBox, ComboBoxItem A_92, ComboBoxItem A_95, ComboBoxItem A_98, TextBlock priceTextBlock)
        {
            double price;

            if (gasComboBox.SelectedItem == A_92)
            {
                price = 0.471;
                priceTextBlock.Text = price.ToString() + " Per liter";
            }

            else if (gasComboBox.SelectedItem == A_95)
            {
                price = 0.785;
                priceTextBlock.Text = price.ToString() + " Per liter";
            }

            else if (gasComboBox.SelectedItem == A_98)
            {
                price = 0.838;
                priceTextBlock.Text = price.ToString() + " Per liter";
            }
        }
    }
}
