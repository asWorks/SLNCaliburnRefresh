using Caliburn.Micro;

namespace CaliburnRefresh.ViewModels
{
    public class BodyViewModel : Screen
    {



        private string _Body;
        public string Body
        {
            get { return _Body; }
            set
            {
                if (value != _Body)
                {
                    _Body = value;
                    NotifyOfPropertyChange(() => Body);
                    //  isDirty = true;
                }
            }
        }



        private string _BodyMessage;
        public string BodyMessage
        {
            get { return _BodyMessage; }
            set
            {
                if (value != _BodyMessage)
                {
                    _BodyMessage = value;
                    NotifyOfPropertyChange(() => BodyMessage);
                    //  isDirty = true;
                }
            }
        }



        private int _Number;
        public int Number
        {
            get { return _Number; }
            set
            {
                if (value != _Number)
                {
                    _Number = value;
                    NotifyOfPropertyChange(() => Number);
                    //  isDirty = true;
                }
            }
        }


        public void Save()
        {
            
        }


    }
}
