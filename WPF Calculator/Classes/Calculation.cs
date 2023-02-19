using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Calculator.Classes
{
    internal class Calculation : ICalcable
    {
        public void Calc(TextBlock Val)
        {
            int index = 0;

            if (Val.Text.Contains("+"))
            {
                index = Val.Text.IndexOf("+");
            }

            else if (Val.Text.Contains("-"))
            {
                index = Val.Text.IndexOf("-");
            }

            else if (Val.Text.Contains("*"))
            {
                index = Val.Text.IndexOf("*");
            }

            else if (Val.Text.Contains("/"))
            {
                index = Val.Text.IndexOf("/");
            }

            else
            {
                MessageBox.Show("Select an action", "Error", MessageBoxButton.OK);
            }

            string op = Val.Text.Substring(index, 1);
            double op1 = Convert.ToDouble(Val.Text.Substring(0, index));
            double op2 = Convert.ToDouble(Val.Text.Substring(index + 1, (Val.Text.Length - index - 1)));

            if (op == "+")
            {
                Val.Text = "";
                Val.Text += op1 + op2;
            }

            else if (op == "-")
            {
                Val.Text = "";
                Val.Text += op1 - op2;
            }

            else if (op == "*")
            {
                Val.Text = "";
                Val.Text += op1 * op2;
            }

            else
            {
                Val.Text = "";
                Val.Text += op1 / op2;
            }
        }
    }
}
