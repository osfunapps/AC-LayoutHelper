using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace Remotes_App_Translation_Project.tools
{
    class UserSettings
    {

        public static UserSettings instance;

        public UserSettings(){}

        public static UserSettings GetInstance()
        {
            if (instance != null) return instance;
            return new UserSettings();
        }


        public void LoadSettings()
        {
        }

        public void SaveSettings()
        {
            Settings.Default.Upgrade(); 
        }
    }
}
