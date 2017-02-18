using AutoMapper;
using Caliburn.Micro;
using CaliburnRefresh.Events;
using CaliburnRefresh.Interfaces;
using CaliburnRefresh.Models;
using System;
using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShellViewModel, IHandle<Events.EventMessage>
    {

        private readonly IEventAggregator _events;
        KundenViewModel kdViewModel;
        TermineViewModel tViewModel;
        TabsViewModel tabsViewModel;
        TestViewModel testVM;


        private HeaderBaseViewModel _HeaderViewModel;
        public HeaderBaseViewModel HeaderViewModel
        {
            get { return _HeaderViewModel; }
            set
            {
                if (value != _HeaderViewModel)
                {
                    _HeaderViewModel = value;
                    NotifyOfPropertyChange(() => HeaderViewModel);
                    //  isDirty = true;
                }
            }
        }


        private BodyViewModel _bodyViewModel;
        public BodyViewModel bodyViewModel
        {
            get { return _bodyViewModel; }
            set
            {
                if (value != _bodyViewModel)
                {
                    _bodyViewModel = value;
                    NotifyOfPropertyChange(() => bodyViewModel);
                    //  isDirty = true;
                }
            }
        }

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
        public ShellViewModel(TermineViewModel TermineVM, KundenViewModel kdViewModel, TestViewModel tvm, TabsViewModel _tabsViewModel, IEventAggregator Events)
        {
            _events = Events;
            testVM = tvm;
            tViewModel = TermineVM;
            tabsViewModel = _tabsViewModel;
            this.kdViewModel = kdViewModel;
            ActivateItem(kdViewModel);
            Events.Subscribe(this);

        }

        public ShellViewModel()
        {

        }




        public void Kunden()
        {
            ActivateItem(kdViewModel);
        }
        public void Termine()
        {
            ActivateItem(tViewModel);
        }
        public void Tabs()
        {
            ActivateItem(tabsViewModel);
        }

        public void LoadHeaderOne()
        {

            HeaderModel hm = new HeaderModel();
            hm.Header = "Header One Neu";
            hm.Message = "Ganz kurz -   ";
            hm.Body = "Body";
            hm.BodyMessage = "This is the bodymessage";
            hm.Number = 4;



            IMapper mapper = AutoMapperHelper.DoMappings();

            var dest = mapper.Map<HeaderModel, HeaderNumberOneViewModel>(hm);



            BodyViewModel body = mapper.Map<HeaderModel, BodyViewModel>(hm);


            bodyViewModel = body;



            HeaderViewModel = dest;
        }

        public void LoadHeaderTwo()
        {
            //HeaderViewModel = new HeaderNumberTwoViewModel("Header Two", "Experten raten zum Weißanstrich mit einer speziellen Farbe, die in jedem Gartencenter und -fachhandel erhältlich ist. Der helle Farbton reflektiert die Sonnenstrahlen, verhindert so eine zu starke Erwärmung der Rinde und beugt dadurch Spannungsrissen vor, so der Bundesverband Garten-, Landschafts- und Sportplatzbau (BGL). Vor dem Anstrich muss man den Stamm vorsichtig von Moos und Flechten befreien.");
            HeaderModel hm = new HeaderModel();
            hm.Header = "Header Two Neu";
            hm.Message = "Experten raten zum Weißanstrich mit einer speziellen Farbe, die in jedem Gartencenter und -fachhandel erhältlich ist";
            hm.Body = "Body for Model Two";
            hm.BodyMessage = "This is the bodymessage for M2";
            hm.Number = 26;



            IMapper mapper = AutoMapperHelper.DoMappings();

            var dest = mapper.Map<HeaderModel, HeaderNumberTwoViewModel>(hm);



            BodyViewModel body = mapper.Map<HeaderModel, BodyViewModel>(hm);


            bodyViewModel = body;



            HeaderViewModel = dest;
        }

        public void SaveHeaderOne()
        {
            HeaderModel hm = new HeaderModel();
            IMapper mapper = AutoMapperHelper.DoMappings();

            //Comment

            hm = mapper.Map<BodyViewModel, HeaderModel>(bodyViewModel);
            mapper.Map<HeaderNumberOneViewModel, HeaderModel>((HeaderNumberOneViewModel)HeaderViewModel, hm);
            //mapper.Map<HeaderBaseViewModel, HeaderModel>(HeaderViewModel, hm);

            var x = hm;






        }



        public void SaveHeaderTwo()
        {
            HeaderModel hm = new HeaderModel();
            IMapper mapper = AutoMapperHelper.DoMappings();

            hm = mapper.Map<BodyViewModel, HeaderModel>(bodyViewModel);
            // hm = mapper.Map<HeaderBaseViewModel, HeaderModel>(HeaderViewModel);
            mapper.Map<HeaderBaseViewModel, HeaderModel>(HeaderViewModel, hm);

            var x = hm;



        }


        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();



        }


    }
}
