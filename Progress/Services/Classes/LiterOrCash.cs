using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cash_Register.Services.Classes
{
    internal class LiterOrCash
    {
        MainWindow mainWindow;
        public LiterOrCash(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Pay(RadioButton radioButton, TextBox litersTextBox, TextBox cashTextBox, TextBlock paymentTextBlock, MarkPrice markPrice)
        {

            if (radioButton.Name == "litersRadioButton")
            {
                litersTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(litersTextBox.Text) * double.Parse(markPrice.Mark_Price());
                    paymentTextBlock.Text = payment.ToString("0.00");
                };

            }

            else if (radioButton.Name == "cashRadioButton")
            {
                cashTextBox.TextChanged += (sender, args) =>
                {
                    double payment = double.Parse(litersTextBox.Text) / double.Parse(markPrice.Mark_Price());
                    paymentTextBlock.Text = payment.ToString("0.00");
                };
            }
        }
    }
}