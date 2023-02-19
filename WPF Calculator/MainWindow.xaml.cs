using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculator.Classes;
using Calculator.Interfaces;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Val.Text += button.Content.ToString();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            ICalcable calcable = new Calculation();
            calcable.Calc(Val);
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Val.Text = "";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Back back = new();
            back.GetBack(Val);
        }
    }
}
