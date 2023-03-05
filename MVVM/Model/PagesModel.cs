using MVVM.View.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    internal class PagesModel : IPagesModel
    {
        public FirstPage FirstButtonClicked()
        {
            return new FirstPage();
        }

        public SecondPage SecondButtonClicked()
        {
            return new SecondPage();
        }

        public ThirdPage ThirdButtonClicked()
        {
            return new ThirdPage();
        }
    }

}