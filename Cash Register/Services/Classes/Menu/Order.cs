using Cash_Register.Services.Classes.Gas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Services.Classes.Menu
{
    internal class Order
    {
        double pay;
        public void Pay(CheckBox checkBox, TextBox hod_dogTextBox, TextBox hamburgerTextBox, TextBox friesTextBox, TextBox colaTextBox)
        {
            double _pay;
            GetMenuPrice getMenuPrice = new();
            getMenuPrice.Menu_Price(checkBox);

            if (checkBox.Name == "hod_dogCheckBox")
            {
                hod_dogTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(hod_dogTextBox.Text) * double.Parse(getMenuPrice.Menu_Price());

                    if (pay != 0)
                    {
                        _pay = pay;
                        pay = payment + _pay;
                    }

                    else
                    {
                        pay = payment;
                    }
                };
            }

            else if (checkBox.Name == "hamburgerCheckBox")
            {
                hamburgerTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(hamburgerTextBox.Text) * double.Parse(getMenuPrice.Menu_Price());

                    if (pay != 0)
                    {
                        _pay = pay;
                        pay = payment + _pay;
                    }

                    else
                    {
                        pay = payment;
                    }
                };
            }

            else if (checkBox.Name == "friesCheckBox")
            {
                friesTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(friesTextBox.Text) * double.Parse(getMenuPrice.Menu_Price());

                    if (pay != 0)
                    {
                        _pay = pay;
                        pay = payment + _pay;
                    }

                    else
                    {
                        pay = payment;
                    }
                };
            }

            else if (checkBox.Name == "colaCheckBox")
            {
                colaTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(colaTextBox.Text) * double.Parse(getMenuPrice.Menu_Price());

                    if (pay != 0)
                    {
                        _pay = pay;
                        pay = payment + _pay;
                    }

                    else
                    {
                        pay = payment;
                    }
                };
            }
        }

        public string Pay()
        {
            return pay.ToString();
        }
    }
}
