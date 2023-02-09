namespace DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty && dateTextBox.Text != String.Empty && adressTextBox.Text != String.Empty && skillTextBox.Text != String.Empty)
            {

                Person person = new()
                {
                    FullName = nameTextBox.Text,
                    Date = dateTextBox.Text,
                    Adress = adressTextBox.Text,
                    Skills = skillTextBox.Text
                };

                MessageBox.Show($"Full Name: {person.FullName}\n" +
                    $"Year of birth: {person.Date}\n" +
                    $"Adress: {person.Adress}\n" +
                    $"Skills: {person.Skills}\n" +
                    $"\nAverage number of characters {(person.FullName.Length + person.Date.Length + person.Adress.Length + person.Skills.Length) / 2}\n");

                peopleListBox.Items.Add(person);

                nameTextBox.Text = "";
                dateTextBox.Text = "";
                adressTextBox.Text = "";
                skillTextBox.Text = "";
            }

            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}