using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.Classes
{
    internal class Back
    {
        public void GetBack(TextBlock Val)
        {
            if (Val.Text.Length > 0)
            {
                Val.Text = Val.Text.Substring(0, Val.Text.Length - 1);
            }
        }
    }
}
