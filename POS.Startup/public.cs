using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Startup
{
    public class AppSetting
    {
        private string _AppMode = string.Empty;
        public string AppPath
        {
            get
            {
                return Application.StartupPath + "\\AppName.txt";
            }
        }
        public string ReadApplicationMode()
        {
            
            try
            {
                if (string.IsNullOrEmpty(this._AppMode))
                {
                    if (File.Exists(this.AppPath))
                    {
                        using (StreamReader reader = new StreamReader(this.AppPath))
                        {
                            this._AppMode = reader.ReadLine();
                        }
                    }
                }
                return this._AppMode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void WriteApplicationMode(string AppMode)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(this.AppPath))
                {
                    writer.WriteLine(AppMode);
                    this._AppMode = AppMode;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
