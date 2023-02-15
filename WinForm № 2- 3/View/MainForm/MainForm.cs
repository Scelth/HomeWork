using DZ.Model;
using DZ.Presenter;
using DZ.Presenter.MyFormPresenter;
using Newtonsoft.Json;


namespace DZ
{
    public partial class MainForm : Form
    {
        public ListBox PeopleListBox => peopleListBox;

        private MainAddButtonPresenter addButtonPresenter;
        private MainPeopleListBoxPresenter peopleListBoxPresenter;

        public MainForm()
        {
            InitializeComponent();

            addButtonPresenter = new MainAddButtonPresenter(this, nameTextBox, dateTextBox, adressTextBox, skillTextBox);
            peopleListBoxPresenter = new MainPeopleListBoxPresenter(this);
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