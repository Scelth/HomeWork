using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Services.Classes.Menu
{
    internal class GetMenuPrice
    {
        double price;
        public void Menu_Price(CheckBox checkBox)
        {
            if (checkBox.Name == "hot_dogCheckBox")
            {
                price = 2.5;
            }

            else if (checkBox.Name == "hamburgerCheckBox")
            {
                price = 3;
            }

            else if (checkBox.Name == "friesCheckBox")
            {
                price = 1.5;
            }

            else if (checkBox.Name == "colaCheckBox")
            {
                price = 2;
            }
        }

        public string Menu_Price()
        {
            return price.ToString();
        }
    }
}