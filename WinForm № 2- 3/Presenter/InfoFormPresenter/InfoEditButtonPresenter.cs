using DZ.Model;
using DZ.Presenter.EditFormPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DZ.Presenter.InfoFormPresenter
{
    internal class InfoEditButtonPresenter
    {
        public Person person;

        private InfoForm view;
        private Label nameLabel;
        private Label dateLabel;
        private Label adressLabel;
        private Label skillLabel;

        public InfoEditButtonPresenter(InfoForm view, Person person, Label nameLabel, Label dateLabel, Label adressLabel, Label skillLabel)
        {
            this.view = view;

            nameLabel.Text = person.FullName;
            dateLabel.Text = person.Date;
            adressLabel.Text = person.Adress;
            skillLabel.Text = person.Skills;

            this.person = person;

            this.nameLabel = nameLabel;
            this.dateLabel = dateLabel;
            this.adressLabel = adressLabel;
            this.skillLabel = skillLabel;
        }

        public void EditButton()
        {
            EditForm editForm = new EditForm(person);
            editForm.ShowDialog();

            nameLabel.Text = person.FullName;
            dateLabel.Text = person.Date;
            adressLabel.Text = person.Adress;
            skillLabel.Text = person.Skills;
        }
    }
}
