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
using DZ.Presenter.InfoFormPresenter;

namespace DZ
{
    public partial class InfoForm : Form
    {
        public Person person;

        private InfoEditButtonPresenter editButtonPresenter;

        private MainForm mainForm;

        public InfoForm(Person person)
        {
            InitializeComponent();

            this.person = person;

            editButtonPresenter = new InfoEditButtonPresenter(this, this.person, nameLabel, dateLabel, adressLabel, skillLabel);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButtonPresenter.EditButton();
        }
    }
}
