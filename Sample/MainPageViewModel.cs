using Caliburn.Micro;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace caliburn_micro_winrt_getting_started
{
    public class MainPageViewModel : Screen
    {
        public void ShowDialog(FrameworkElement source)
        {
            DialogService.ShowDialog<DialogViewModel>(PlacementMode.Left, source);
        }
    }
}
