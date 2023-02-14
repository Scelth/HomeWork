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
        Person person = new();
        public MyForm MyFormRef { get; set; } = new();
        public EditForm(/*Person person*/)
        {
            InitializeComponent();

            /*person.FullName = nameTextBox.Text;
            person.Date = dateTextBox.Text;
            person.Adress = adressTextBox.Text;
            person.Skills = skillTextBox.Text;

            this.person.FullName = person.FullName;
            this.person.Date = person.Date;
            this.person.Adress = person.Adress;
            this.person.Skills = person.Skills;
            */
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MyFormRef.person = person;

            this.Close();
        }
    }
}
