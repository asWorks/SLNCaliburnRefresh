using Caliburn.Micro;
using System.ComponentModel.Composition;

namespace CaliburnRefresh.ViewModels
{
    [Export(typeof(TabsViewModel))]
    public class TabsViewModel : Conductor<IScreen>.Collection.OneActive
    {
        int count = 0;
        public void OpenTab()
        {
            ActivateItem(new TabViewModel
            {
                DisplayName = "Tab " + count++
            });
        }

        public void CloseItem(TabViewModel child)
        {
            child.TryClose();
           // Items.Remove(child);
        }
    }
}
