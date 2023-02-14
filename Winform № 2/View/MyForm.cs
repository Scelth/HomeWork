using DZ.Classes;
using DZ.Model;
using DZ.Presenter;
using Newtonsoft.Json;


namespace DZ
{
    public partial class MyForm : Form
    {
        public Person person = new();
        List<Person> people = new List<Person>();
        public Person newPerson;
        public MyForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty && dateTextBox.Text != String.Empty && adressTextBox.Text != String.Empty && skillTextBox.Text != String.Empty)
            {
                people.Add(new Person
                {
                    FullName = nameTextBox.Text,
                    Date = dateTextBox.Text,
                    Adress = adressTextBox.Text,
                    Skills = skillTextBox.Text
                });

                person = people[people.Count - 1];

                peopleListBox.Items.Add(person);

                nameTextBox.Text = "";
                dateTextBox.Text = "";
                adressTextBox.Text = "";
                skillTextBox.Text = "";

                SerializePresenter serializeService = new(people);
            }

            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void peopleListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (peopleListBox.SelectedItem != null)
            {
                Person selectedPerson = (Person)peopleListBox.SelectedItem;
                InfoForm info = new InfoForm(selectedPerson);
                info.ShowDialog();
            }
        }
    }
}
