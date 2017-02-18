using Caliburn.Micro;
using System;

namespace CaliburnRefresh.ViewModels
{
    public class TabViewModel : Screen
    {

        public bool CanControlClose { get; set; }
        public string Caption { get; set; }
        public string Note { get; set; }

        public override void CanClose(Action<bool> callback)
        {

            base.CanClose(callback);
            callback(CanControlClose);
        }

    }
}
