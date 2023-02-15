using DZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.Presenter.MyFormPresenter
{
    internal class MyPeopleListBoxPresenter
    {
        private MyForm view;
        public MyPeopleListBoxPresenter(MyForm view)
        {
            this.view = view;
        }

        public void PeopleList()
        {
            if (view.PeopleListBox.SelectedItem != null)
            {
                Person selectedPerson = (Person)view.PeopleListBox.SelectedItem;
                InfoForm info = new InfoForm(selectedPerson);
                info.ShowDialog();

                selectedPerson.FullName = info.person.FullName;
                selectedPerson.Date = info.person.Date;
                selectedPerson.Adress = info.person.Adress;
                selectedPerson.Skills = info.person.Skills;

                view.PeopleListBox.Items[view.PeopleListBox.SelectedIndex] = selectedPerson;
            }
        }
    }
}
