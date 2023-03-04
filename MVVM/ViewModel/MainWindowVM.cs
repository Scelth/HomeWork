using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM.View.UserControls;

namespace MVVM.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        private object selectedPage;

        public object SelectedPage
        {
            get { return selectedPage; }
            set
            {
                if (selectedPage != value)
                {
                    selectedPage = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void FirstButtonClicked()
        {
            SelectedPage = new FirstPage();
        }

        public void SecondButtonClicked()
        {
            SelectedPage = new SecondPage();
        }

        public void ThirdButtonClicked()
        {
            SelectedPage = new ThirdPage();
        }
    }
}