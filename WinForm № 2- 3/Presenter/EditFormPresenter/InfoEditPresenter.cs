using DZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.Presenter.EditFormPresenter
{
    internal class InfoEditPresenter
    {
        private EditForm view;
        private TextBox nameTextBox;
        private TextBox dateTextBox;
        private TextBox adressTextBox;
        private TextBox skillTextBox;

        private Person person;

        public InfoEditPresenter(EditForm view, Person person, TextBox nameTextBox, TextBox dateTextBox, TextBox adressTextBox, TextBox skillTextBox)
        {
            this.view = view;
            this.person = person;

            this.nameTextBox = nameTextBox;
            this.dateTextBox = dateTextBox;
            this.adressTextBox = adressTextBox;
            this.skillTextBox = skillTextBox;
        }

        public void InfoEdit()
        {
            if (person.FullName != nameTextBox.Text || person.Date != dateTextBox.Text || person.Adress != adressTextBox.Text || person.Skills != skillTextBox.Text)
            {
                person.FullName = nameTextBox.Text;
                person.Date = dateTextBox.Text;
                person.Adress = adressTextBox.Text;
                person.Skills = skillTextBox.Text;
            }

            view.Close();
        }
    }
}
