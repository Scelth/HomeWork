using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Classes
{
    internal class LiterOrCash
    {
        public void Pay(RadioButton radioButton, TextBox litersTextBox, TextBox cashTextBox, TextBlock paymentTextBlock)
        {
            if (radioButton.Name == "litersRadioButton")
            {
                double payment = Double.Parse(litersTextBox.Text) * 0.471;
                paymentTextBlock.Text = payment.ToString();
                
            }

            else if (radioButton.Name == "cashRadioButton")
            {
                double payment = Double.Parse(litersTextBox.Text) / 0.471;
                paymentTextBlock.Text = payment.ToString();
            }
        }
    }
}