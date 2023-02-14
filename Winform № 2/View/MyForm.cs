using DZ.Classes;
using DZ.Model;
using DZ.Presenter;
using Newtonsoft.Json;


namespace DZ
{
    public partial class MyForm : Form
    {
        public Person person { get; set; } = new();
        List<Person> people = new List<Person>();
        public static short count = 0;
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

                //person = people[count++];

                peopleListBox.Items.Add(people);

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
            InfoForm info = new(person);
            info.ShowDialog();
        }
    }
}