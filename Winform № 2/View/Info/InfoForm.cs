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
    public partial class InfoForm : Form
    {
        public Person person { get; set; } = new();
        public InfoForm(Person person)
        {
            InitializeComponent();

            nameLabel.Text = person.FullName;
            dateLabel.Text = person.Date;
            adressLabel.Text = person.Adress;
            skillLabel.Text = person.Skills;

            this.person = person;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(person);
            editForm.ShowDialog();
            if (editForm.PersonChanged)
            {
                nameLabel.Text = person.FullName;
                dateLabel.Text = person.Date;
                adressLabel.Text = person.Adress;
                skillLabel.Text = person.Skills;
            }
        }
    }
}
