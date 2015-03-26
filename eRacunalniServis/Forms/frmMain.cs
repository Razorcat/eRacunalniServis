using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(Global.GetString("quit"), "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }
        private DialogResult PreLogoutConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(Global.GetString("logout"), "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmDodajKorisnika frmDK = new frmDodajKorisnika();
            frmDK.MdiParent = this;
            frmDK.WindowState = FormWindowState.Maximized;
            frmDK.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PreLogoutConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
                Application.Restart();
            }            
        }

        private void dodajProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmDodajProizvod frmDP = new frmDodajProizvod();
            frmDP.MdiParent = this;
            frmDP.WindowState = FormWindowState.Maximized;
            frmDP.Show();
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPretragaProizvoda frmPP = new frmPretragaProizvoda();
            frmPP.MdiParent = this;
            frmPP.WindowState = FormWindowState.Maximized;
            frmPP.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmProdaja frmP = new frmProdaja();
            frmP.MdiParent = this;
            frmP.WindowState = FormWindowState.Maximized;
            frmP.Show();
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPregledKorisnika frmPK = new frmPregledKorisnika();
            frmPK.MdiParent = this;
            frmPK.WindowState = FormWindowState.Maximized;
            frmPK.Show();
        }        
    }
}
