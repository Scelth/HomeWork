using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM.Model;
using Prism.Commands;
using Prism.Mvvm;


namespace MVVM.ViewModel
{
    public class MainWindowVM : BindableBase
    {
        private PagesModel pagesModel { get; set; }
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

        public DelegateCommand FirstButtonCommand { get; }
        public DelegateCommand SecondButtonCommand { get; }
        public DelegateCommand ThirdButtonCommand { get; }

        public MainWindowVM()
        {
            pagesModel = new PagesModel();

            FirstButtonCommand = new DelegateCommand(FirstButtonClicked);
            SecondButtonCommand = new DelegateCommand(SecondButtonClicked);
            ThirdButtonCommand = new DelegateCommand(ThirdButtonClicked);
        }

        private void FirstButtonClicked()
        {
            SelectedPage = pagesModel.FirstButtonClicked();
        }

        private void SecondButtonClicked()
        {
            SelectedPage = pagesModel.SecondButtonClicked();
        }

        private void ThirdButtonClicked()
        {
            SelectedPage = pagesModel.ThirdButtonClicked();
        }
    }
}