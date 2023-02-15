using DZ.Model;
using DZ.Presenter;
using DZ.Presenter.MyFormPresenter;
using Newtonsoft.Json;


namespace DZ
{
    public partial class MyForm : Form
    {
        public ListBox PeopleListBox => peopleListBox;

        private MyAddButtonPresenter addButtonPresenter;
        private MyPeopleListBoxPresenter peopleListBoxPresenter;
        public MyForm()
        {
            InitializeComponent();

            addButtonPresenter = new MyAddButtonPresenter(this, nameTextBox, dateTextBox, adressTextBox, skillTextBox);
            peopleListBoxPresenter = new MyPeopleListBoxPresenter(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addButtonPresenter.AddPeople();
        }

        private void peopleListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            peopleListBoxPresenter.PeopleList();
        }
    }
}