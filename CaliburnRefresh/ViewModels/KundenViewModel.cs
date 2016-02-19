using Caliburn.Micro;
using CaliburnRefresh.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaliburnRefresh.Events;
using System.ComponentModel.Composition;
using CaliburnRefresh.ViewModels;
using CaliburnRefresh.Interfaces;




namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(KundenViewModel))]
    public class KundenViewModel : Screen,IKundenViewModel, IHandle<Events.EventMessage>
    {
        private readonly IEventAggregator _events;
        [ImportingConstructor]
        public KundenViewModel(IEventAggregator Events)
        {
            this._events = Events;
            Display = "Kunden";
            Name = "Init";
        }

        public KundenViewModel()
        {

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


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    NotifyOfPropertyChange(() => Name);
                    NotifyOfPropertyChange(() => CanDoClick);
     
                    //  isDirty = true;
                }
            }
        }

        public void DoReset()
        {
            Name = "Init";
        }

        public bool CanReset
        {
            get { return Name != "Init"; }
        }
        public void DoClick()
        {
            Name = "Click is done : " + DateTime.Now;  
        }

        public bool CanDoClick
        {
           get{ return Name == "Init"; }
        }

        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }

        public override void CanClose(Action<bool> callback)
        {
            callback(Name == "Init");
        }
    }
}
