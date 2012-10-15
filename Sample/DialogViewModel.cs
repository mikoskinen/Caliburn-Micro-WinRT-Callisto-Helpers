using System;
using Caliburn.Micro;
using Windows.UI.Popups;

namespace caliburn_micro_winrt_getting_started
{
    public class DialogViewModel : Screen
    {
        public async void ShowMessage()
        {
            var dlg = new MessageDialog("Hello from Dialog");

            await dlg.ShowAsync();
        }
    }
}
