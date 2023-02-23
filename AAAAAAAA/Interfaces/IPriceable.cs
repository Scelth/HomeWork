using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register
{
    interface IPriceable
    {
        public void Price(ComboBox gasComboBox, ComboBoxItem A_92, ComboBoxItem A_95, ComboBoxItem A_98, TextBlock priceTextBlock);
    }
}
