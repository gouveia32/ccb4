using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("pt-BR");
            DevExpress.Skins.SkinManager.EnableFormSkins();
            String pele;

            try
            {
                Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\ccb4");
                pele = regKey.GetValue("Skin").ToString();
            }
            catch
            {
                pele = "Visual Studio 2013 Blue";
            }

            UserLookAndFeel.Default.SetSkinStyle(pele);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new frmLogin().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
