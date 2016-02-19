using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaliburnRefresh.Events;
using System.ComponentModel.Composition;
using CaliburnRefresh.Interfaces;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(TermineViewModel))]
    public class TermineViewModel : Screen, ITermineViewModel, IHandle<Events.EventMessage>
    {


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


        [ImportingConstructor]
        public TermineViewModel()
        {
            Display = "Termine";
        }
        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
