using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(HeaderNumberTwoViewModel))]
    public class HeaderNumberTwoViewModel : HeaderBaseViewModel
    {

        public HeaderNumberTwoViewModel()
        {

        }

        public HeaderNumberTwoViewModel(string header, string message)
            : base(header, message)
        {

        }
    }
}
