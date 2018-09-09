using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Startup
{
    public partial class frmStratup : Form
    {

        private readonly AppSetting setting = default(AppSetting);
        public frmStratup()
        {
            InitializeComponent();
        }
        public frmStratup(AppSetting setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var ConfigInstance = StartupConfig.CreateInstance();
            if (string.IsNullOrEmpty(ConfigInstance.AppMode))
            {
                if (!string.IsNullOrEmpty(cmbMode.GetItemText(cmbMode.SelectedItem)) && cmbMode.GetItemText(cmbMode.SelectedItem) != "SELECT")
                {
                    ConfigInstance.AppMode = cmbMode.GetItemText(cmbMode.SelectedItem);
                    this.Close();
                    if (ConfigInstance.AppMode == "SERVER")
                    {
                        Server.ServerStartupForm obj = new Server.ServerStartupForm();
                        obj.Show();
                    }
                    else if (ConfigInstance.AppMode == "CLIENT")
                    {
                        Client.ClentStartupFrom obj = new Client.ClentStartupFrom();
                        obj.Show();
                    }
                    setting.WriteApplicationMode(ConfigInstance.AppMode);
                }
            }
        }
    }
}
