using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Services.Classes
{
    internal class GetPrice
    {
        public double price;

        public string SetPrice(ComboBox gasComboBox, ComboBoxItem A_92, ComboBoxItem A_95, ComboBoxItem A_98)
        {
            if (gasComboBox.SelectedItem == A_92)
            {
                price = 0.471;
            }

            else if (gasComboBox.SelectedItem == A_95)
            {
                price = 0.785;
            }

            else if (gasComboBox.SelectedItem == A_98)
            {
                price = 0.838;
            }

            return price.ToString();
        }
    }
}
