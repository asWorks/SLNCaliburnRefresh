using Caliburn.Micro;

namespace CaliburnRefresh.ViewModels
{
    public class HeaderBaseViewModel : Screen
    {


        public HeaderBaseViewModel()
        {
            //New Comment
        }

        public HeaderBaseViewModel(string header, string message)
        {
            Header = header;
            Message = message;
        }



        private string _Header;
        public string Header
        {
            get { return _Header; }
            set
            {
                if (value != _Header)
                {
                    _Header = value;
                    NotifyOfPropertyChange(() => Header);
                    //  isDirty = true;
                }
            }
        }



        private string _Message;
        public string Message
        {
            get { return _Message; }
            set
            {
                if (value != _Message)
                {
                    _Message = value;
                    NotifyOfPropertyChange(() => Message);
                    //  isDirty = true;
                }
            }
        }


        public void RunMessage()

        {

        }
    }
}
