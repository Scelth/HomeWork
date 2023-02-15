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
using DZ.Presenter.EditFormPresenter;

namespace DZ
{
    public partial class EditForm : Form
    {
        public bool PersonChanged { get; private set; }
        private Person person;

        private InfoEditPresenter infoEditPresenter;
        public EditForm(Person person)
        {
            InitializeComponent();

            this.person = person;

            infoEditPresenter = new InfoEditPresenter(this, this.person, nameTextBox, dateTextBox, adressTextBox, skillTextBox);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            infoEditPresenter.InfoEdit();
        }
    }
}
