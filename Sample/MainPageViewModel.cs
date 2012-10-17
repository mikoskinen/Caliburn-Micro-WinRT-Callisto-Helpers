using Caliburn.Micro;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace caliburn_micro_winrt_getting_started
{
    public class MainPageViewModel : Screen
    {
        private bool currentValue;
        public bool CurrentValue
        {
            get { return this.currentValue; }
            set { this.currentValue = value; NotifyOfPropertyChange(() => CurrentValue); }
        }

        public void ShowDialog(FrameworkElement source)
        {
            DialogService.ShowDialog<DialogViewModel>(PlacementMode.Left, source);
        }

        public void ShowSettingsDialog()
        {
            DialogService.ShowSettings<SettingsViewModel>(onInitialize: vm => vm.TestSetting = this.CurrentValue, onClosed: (vm, view) => CurrentValue = vm.TestSetting);
        }
    }
}
