using System;
using System.Windows.Forms;
using System.IO;

namespace IDNS
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStart.Checked)
            {
                ToggleAutoStart(0);
                
            }
            else
            {
                ToggleAutoStart(1);
            }
        }

        private void ToggleAutoStart(int i)
        {
            string appPath = this.GetType().Assembly.Location;
            Microsoft.Win32.RegistryKey RKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (i == 0)
            {
                
                RKey.SetValue("IDNS", appPath);
            }
            else
            {
                RKey.DeleteValue("IDNS");
            }
            
            
        }

        private bool IsAutoStart()
        {
            Microsoft.Win32.RegistryKey RKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (RKey.GetValue("IDNS") != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (IsAutoStart())
            {
                autoStart.Checked = true;
            }
            if (File.Exists("auto"))
            {
                autoStartServer.Checked = true;
            }
        }

        private void AutoStartServer_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStartServer.Checked)
            {
                if (!File.Exists("auto"))
                {
                    File.Create("auto"); 
                }
            }
            else
            {
                if (File.Exists("auto"))
                {
                    File.Delete("auto");
                }
            }
        }
    }
}
