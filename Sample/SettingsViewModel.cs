using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace caliburn_micro_winrt_getting_started
{
    public sealed class SettingsViewModel : Screen
    {
        public SettingsViewModel()
        {
            this.DisplayName = "My Settings";
        }

        private bool testSetting;
        public bool TestSetting
        {
            get { return this.testSetting; }
            set { this.testSetting = value; NotifyOfPropertyChange(() => TestSetting); }
        }
    }
}
