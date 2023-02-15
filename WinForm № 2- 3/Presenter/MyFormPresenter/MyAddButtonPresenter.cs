using DZ.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ.Presenter.SerializePresenter;

namespace DZ.Presenter.MyFormPresenter
{
    internal class MyAddButtonPresenter
    {
        public Person person = new();
        List<Person> people = new List<Person>();

        private MyForm view;
        private TextBox nameTextBox;
        private TextBox dateTextBox;
        private TextBox adressTextBox;
        private TextBox skillTextBox;

        public MyAddButtonPresenter(MyForm view, TextBox nameTextBox, TextBox dateTextBox, TextBox adressTextBox, TextBox skillTextBox)
        {
            this.view = view;

            this.nameTextBox = nameTextBox;
            this.dateTextBox = dateTextBox;
            this.adressTextBox = adressTextBox;
            this.skillTextBox = skillTextBox;
        }

        public void AddPeople()
        {
            if (nameTextBox.Text != String.Empty && dateTextBox.Text != String.Empty && adressTextBox.Text != String.Empty && skillTextBox.Text != String.Empty)
            {
                people.Add(new Person
                {
                    FullName = nameTextBox.Text,
                    Date = dateTextBox.Text,
                    Adress = adressTextBox.Text,
                    Skills = skillTextBox.Text
                });

                person = people[people.Count - 1];

                view.PeopleListBox.Items.Add(person);

                nameTextBox.Text = "";
                dateTextBox.Text = "";
                adressTextBox.Text = "";
                skillTextBox.Text = "";

                SerializPresenter serializeService = new(people);
            }

            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
