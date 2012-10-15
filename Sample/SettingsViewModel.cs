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

        public bool TestSetting { get; set; }
    }
}
