using Cash_Register.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Cash_Register.Services.Classes.Gas;

namespace Cash_Register.Services.Classes.Gas
{
    internal class GasPrice : IGasPrice
    {
        public void Price(ComboBox gasComboBox, ComboBoxItem A_92, ComboBoxItem A_95, ComboBoxItem A_98, TextBlock priceTextBlock, GetMarkPrice markPrice)
        {

            if (gasComboBox.SelectedItem == A_92 || gasComboBox.SelectedItem == A_95 || gasComboBox.SelectedItem == A_98)
            {
                markPrice.Mark_Price(gasComboBox, A_92, A_95, A_98);
                priceTextBlock.Text = markPrice.Mark_Price() + " Per liter";
            }
        }
    }
}
