using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(TestViewModel))]
         public class TestViewModel:PropertyChangedBase
    {

        public TestViewModel()
        {
            Display = "Test";
        }

        private string _Display;
        public string Display
        {
            get { return _Display; }
            set
            {
                if (value != _Display)
                {
                    _Display = value;
                    NotifyOfPropertyChange(() => Display);
                    //  isDirty = true;
                }
            }
        }
    }
}
