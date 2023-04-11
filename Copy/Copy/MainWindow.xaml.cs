using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Copy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Doc> Docs { get; set; } = new();
        public Doc Doc { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string text = Text.Text;
            int fontSize = 0;
            int.TryParse(FontSize.Text, out fontSize);

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(text))
            {
                Docs.Add(new Doc(name, text, fontSize));
            }

            else
            {
                Docs.Add(Doc.Clone() as Doc);
            }

            Name.Text = "";
            Text.Text = "";
            FontSize.Text = "";
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (docsListBox.SelectedItem != null)
            {
                string name = Name.Text;
                string text = Text.Text;
                int fontSize;
                int.TryParse(FontSize.Text, out fontSize);

                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(text) && fontSize != 0)
                {
                    ((Doc)docsListBox.SelectedItem).Name = name;
                    ((Doc)docsListBox.SelectedItem).Text = text;
                    ((Doc)docsListBox.SelectedItem).FontSize = fontSize;

                    docsListBox.Items.Refresh();
                }

                else
                {
                    MessageBox.Show("Invalid entered data!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                Name.Text = "";
                Text.Text = "";
                FontSize.Text = "";
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Docs.Remove(docsListBox.SelectedItem as Doc);
        }
    }
}
