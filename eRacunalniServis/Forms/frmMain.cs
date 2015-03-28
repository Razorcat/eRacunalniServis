using eRacunalniServis.Forms;
using eRacunalniServis.Forms.Dobavljaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis_Servis.Forms
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
            frmDodajKorisnika frmDK = new frmDodajKorisnika(null,this.Font);
            frmDK.MdiParent = this;            
            frmDK.Show();
            frmDK.WindowState = FormWindowState.Maximized;
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

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPregledKorisnika frmPK = new frmPregledKorisnika();
            frmPK.MdiParent = this;            
            frmPK.Show();
            frmPK.WindowState = FormWindowState.Maximized;
        }

        private void dodajProizvodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmDodajProizvod frmDP = new frmDodajProizvod();
            frmDP.MdiParent = this;            
            frmDP.Show();
            frmDP.WindowState = FormWindowState.Maximized;
        }

        private void promjeniFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            this.Font = fontDialog.Font;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOProgramu frmInfo = new frmOProgramu();
            frmInfo.ShowDialog();
        }

        private void dodajNovogDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmNoviDobavljac frmDP = new frmNoviDobavljac();
            frmDP.MdiParent = this;
            frmDP.Show();
            frmDP.WindowState = FormWindowState.Maximized;
        }             
    }
}
