using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{

    [Export(typeof(HeaderNumberOneViewModel))]
    public class HeaderNumberOneViewModel : HeaderBaseViewModel
    {
        public HeaderNumberOneViewModel() : base()
        {

        }

        public HeaderNumberOneViewModel(string header, string message)
            : base(header, message)
        {

        }
    }
}
