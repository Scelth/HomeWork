namespace DZ
{
    public partial class Form1 : Form
    {
        Person person = new();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty && dateTextBox.Text != String.Empty && adressTextBox.Text != String.Empty && skillTextBox.Text != String.Empty)
            {

                person.FullName = nameTextBox.Text;
                person.Date = dateTextBox.Text;
                person.Adress = adressTextBox.Text;
                person.Skills = skillTextBox.Text;

                MessageBox.Show($"Full Name: {person.FullName}\n" +
                    $"Year of birth: {person.Date}\n" +
                    $"Adress: {person.Adress}\n" +
                    $"Skills: {person.Skills}\n", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void peopleListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Full Name: {person.FullName}\n" +
                    $"Year of birth: {person.Date}\n" +
                    $"Adress: {person.Adress}\n" +
                    $"Skills: {person.Skills}\n",
                    $"Average number of characters: {(person.FullName.Length + person.Date.Length + person.Adress.Length + person.Skills.Length) / 3}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
