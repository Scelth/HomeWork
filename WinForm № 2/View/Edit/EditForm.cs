using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DZ.Model;

namespace DZ
{
    public partial class EditForm : Form
    {
        public bool PersonChanged { get; private set; }
        private Person person;
        public EditForm(Person person)
        {
            InitializeComponent();

            this.person = person;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (person.FullName != nameTextBox.Text || person.Date != dateTextBox.Text || person.Adress != adressTextBox.Text || person.Skills != skillTextBox.Text)
            {
                person.FullName = nameTextBox.Text;
                person.Date = dateTextBox.Text;
                person.Adress = adressTextBox.Text;
                person.Skills = skillTextBox.Text;
                PersonChanged = true;
            }
            Close();
        }
    }
}
