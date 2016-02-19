using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloSilverlight
{
 
        public class HelloBootstrapper : BootstrapperBase
        {
            public HelloBootstrapper()
            {
                //Start();
            }
            protected HelloBootstrapper(bool useApplication = true)
                : base(useApplication)
            {
                
            }

            protected override void OnStartup(object sender, StartupEventArgs e)
            {
                DisplayRootViewFor<ShellViewModel>();
            }

         
        }
   

}
