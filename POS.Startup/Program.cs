using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Startup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static AppSetting setting;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            setting = new AppSetting();
            string AppMode = setting.ReadApplicationMode();
            if (string.IsNullOrEmpty(AppMode))
            {
                StartupConfig.CreateInstance().AppMode = AppMode;
                Application.Run(new frmStratup(setting));
            }
            else
            {
                if(AppMode== "SERVER")
                {
                    Server.ServerStartupForm obj = new Server.ServerStartupForm();
                    Application.Run(obj);
                }
                else
                {
                    Client.ClentStartupFrom obj = new Client.ClentStartupFrom();
                    Application.Run(obj);
                }
            }
            
        }

        private static string GetAppMode()
        {
              setting = new AppSetting();
            return setting.ReadApplicationMode();
        }
    }

}
