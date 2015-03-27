using eRacunalniServis_Servis.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
                Application.Run(new frmMain());    
        }
    }
}
