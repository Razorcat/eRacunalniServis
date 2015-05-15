using eRacunalniServis.Forms;
using eRacunalniServis.Forms.Dobavljaci;
using eRacunalniServis.Forms.Izvjestaji;
using eRacunalniServis.Forms.Kupci;
using eRacunalniServis.Forms.Prodaja;
using eRacunalniServis.Forms.Proizvodi;
using eRacunalniServis.Forms.Servis;
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
            DialogResult res = System.Windows.Forms.MessageBox.Show(Global.GetString("quit"), "Izlazak?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            frmDodajKorisnika frmDK = new frmDodajKorisnika(null);
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

        private void pretragaDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmAdministracijaDobavljaca frmDP = new frmAdministracijaDobavljaca();
            frmDP.MdiParent = this;
            frmDP.Show();
            frmDP.WindowState = FormWindowState.Maximized;
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPretragaProizvoda frmPP = new frmPretragaProizvoda();
            frmPP.MdiParent = this;
            frmPP.Show();
            frmPP.WindowState = FormWindowState.Maximized;
        }

        private void nabavaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();            
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmNabavaProizvoda frmNP = new frmNabavaProizvoda();
            frmNP.MdiParent = this;
            frmNP.Show();
            frmNP.WindowState = FormWindowState.Maximized;
        }

        private void noviServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmNoviServis frmNP = new frmNoviServis();
            frmNP.MdiParent = this;
            frmNP.Show();
            frmNP.WindowState = FormWindowState.Maximized;
        }

        private void pregledServisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPregledServisa frmPS = new frmPregledServisa();
            frmPS.MdiParent = this;
            frmPS.Show();
            frmPS.WindowState = FormWindowState.Maximized;
        }

        private void novaProdajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmNovaProdaja frmNP = new frmNovaProdaja();
            frmNP.MdiParent = this;
            frmNP.Show();
            frmNP.WindowState = FormWindowState.Maximized;
        }

        private void dodajKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmDodajKupca frmDK = new frmDodajKupca();
            frmDK.MdiParent = this;
            frmDK.Show();
            frmDK.WindowState = FormWindowState.Maximized;
        }

        private void administacijaKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmAdministracijaKupaca frmAK = new frmAdministracijaKupaca();
            frmAK.MdiParent = this;
            frmAK.Show();
            frmAK.WindowState = FormWindowState.Maximized;
        }

        private void narudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmNarudzbe frmN = new frmNarudzbe();
            frmN.MdiParent = this;
            frmN.Show();
            frmN.WindowState = FormWindowState.Maximized;
        }

        private void stanjeSkladištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmStanjeSkladista frmSS = new frmStanjeSkladista();
            frmSS.MdiParent = this;
            frmSS.Show();
            frmSS.WindowState = FormWindowState.Maximized;
        }

        private void stanjeSkladištaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmReportProizvodi frmRSS = new frmReportProizvodi();
            frmRSS.MdiParent = this;
            frmRSS.Show();
            frmRSS.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmReportProdajaByDatum frmRPBD = new frmReportProdajaByDatum();
            frmRPBD.MdiParent = this;
            frmRPBD.Show();
            frmRPBD.WindowState = FormWindowState.Maximized;
        }

        private void povijestProdajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDobrodosli.Hide();
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmPregledProdaje frmPP = new frmPregledProdaje();
            frmPP.MdiParent = this;
            frmPP.Show();
            frmPP.WindowState = FormWindowState.Maximized;
        }
       
    }
}
