using System;
using System.Windows.Forms;

namespace DZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            short num = 1992;

            if (guessTextBox.Text != String.Empty)
            {
                Player player = new()
                {
                    Num = Int16.Parse(guessTextBox.Text)
                };

                guessTextBox.Text = "";

                MessageBox.Show($"Your choice: {player.Num}", "Choice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guessListBox.Items.Add(player);

                if (player.Num == num)
                {
                    MessageBox.Show("You Won!!!", "Congratulate!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("You Lose. Try again :(", "We are sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}