using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Services.Classes.Gas
{
    internal class LiterOrCash
    {
        public void Pay(RadioButton radioButton, TextBox litersTextBox, TextBox cashTextBox, TextBlock gasPaymentTextBlock, GetMarkPrice markPrice)
        {

            if (radioButton.Name == "litersRadioButton")
            {
                litersTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(litersTextBox.Text) * markPrice.Mark_Price();
                    gasPaymentTextBlock.Text = payment.ToString("0.00");
                };

            }

            else if (radioButton.Name == "cashRadioButton")
            {
                cashTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(litersTextBox.Text) / markPrice.Mark_Price();
                    gasPaymentTextBlock.Text = payment.ToString("0.00");
                };
            }
        }
    }
}