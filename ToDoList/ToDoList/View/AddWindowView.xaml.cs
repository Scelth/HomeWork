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
using System.Windows.Shapes;
using ToDoList.Model;

namespace ToDoList.View
{
    public partial class AddWindowView : Window
    {
        public ToDo TmpDo { get; set; } = new ToDo("Name", "Description", ToDo.ToDoType.Home);
        public AddWindowView()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            if (DoNameTextBox.Text != string.Empty && DoDescriptionTextBox.Text != string.Empty && DoTypeComboBox.SelectedItem != null)
            {
                TmpDo.Name = DoNameTextBox.Text;
                TmpDo.Description = DoDescriptionTextBox.Text;

                switch (((ComboBoxItem)DoTypeComboBox.SelectedItem).Content.ToString())
                {
                    case "Work":
                        TmpDo.Type = ToDo.ToDoType.Work;
                        break;
                    case "Home":
                        TmpDo.Type = ToDo.ToDoType.Home;
                        break;
                    case "Emergency":
                        TmpDo.Type = ToDo.ToDoType.Emergency;
                        break;
                    default:
                        break;
                }

                Close();
            }

            else
            {
                MessageBox.Show("Invalid Data to add ToDo");
            }
        }

        public ToDo GetDo()
        {
            return TmpDo;
        }
    }
}
