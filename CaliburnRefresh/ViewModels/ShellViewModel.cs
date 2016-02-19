using Caliburn.Micro;
using CaliburnRefresh.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaliburnRefresh.Events;
using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShellViewModel, IHandle<Events.EventMessage>
    {

        private readonly IEventAggregator _events;
        KundenViewModel kdViewModel;
        TermineViewModel tViewModel;

        TestViewModel testVM;

        //[ImportingConstructor]
        //public ShellViewModel(TermineViewModel TermineDatenVM, KundenViewModel kdViewModel, IEventAggregator Events)
        //{
        //    //Events.Subscribe(this);
        //    //this._events = Events;
        //    //this.tViewModel = TermineDatenVM;
        //    //this.kdViewModel = kdViewModel;
        //    //kdViewModel.Diplay = "Na, bitte. Geht doch :<) ";
        //    //ActiveControl = (NavigationViewModel)new NavigationViewModel();
        //    //kdViewModel = new KundenViewModel();
        //    //ActivateItem(kdViewModel);

        //    this.DisplayName = "Refresh Caliburn";
        //}
        [ImportingConstructor]
        public ShellViewModel(TermineViewModel TermineVM, KundenViewModel kdViewModel, TestViewModel tvm, IEventAggregator Events)
        {
            _events = Events;
            testVM = tvm;
            tViewModel = TermineVM;
           this.kdViewModel = kdViewModel;
            ActivateItem(kdViewModel);
            Events.Subscribe(this);

        }

        public ShellViewModel()
        {

        }

        int count = 1;

        public void OpenTab()
        {
            ActivateItem(new TabViewModel
            {
                DisplayName = "Tab " + count++
            });
        }



        public void Kunden()
        {
            ActivateItem(kdViewModel);
        }
        public void Termine()
        {
            ActivateItem(tViewModel);
        }
        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
