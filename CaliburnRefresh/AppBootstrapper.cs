using Caliburn.Micro;
using CaliburnRefresh.ViewModels;
using CaliburnRefresh.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnRefresh
{
    public class AppBootstrapper : BootstrapperBase
    {
        CompositionContainer container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            //container = new SimpleContainer();

            //container.Singleton<IWindowManager, WindowManager>();
            //container.Singleton<IEventAggregator, EventAggregator>();
            //container.PerRequest<IShellViewModel, ShellViewModel>();


            container = new CompositionContainer(new AggregateCatalog(AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>()));

            CompositionBatch batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue(container);

            container.Compose(batch);
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            //var instance = container.GetInstance(service, key);
            //if (instance != null)
            //    return instance;

            //throw new InvalidOperationException("Could not locate any instances.");

            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = container.GetExportedValues<object>(contract);

            if (exports.Count() > 0)
            {
                return exports.First();
            }

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        //protected override IEnumerable<object> GetAllInstances(Type service)
        //{
        //    return container.GetAllInstances(service);
        //}

        //protected override void BuildUp(object instance)
        //{
        //    container.BuildUp(instance);
        //}

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<IShellViewModel>();
        }
    }
}
