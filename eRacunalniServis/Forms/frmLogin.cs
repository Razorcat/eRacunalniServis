using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eRacunalniServis_Servis.Data;

namespace eProdaja.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            eRacunalniServis_Servis.Data.Korisnici k = DAKorisnici.SelectByKorisnickoIme(txtbKorisnickoIme.Text, txtbLozinka.Text);
            if (k != null)
            {
                if (k.Uloge.Count > 0)
                {
                    Global.prijavljeniKorisnik = k;
                    this.DialogResult = DialogResult.OK;
                }
                else MessageBox.Show(Global.GetString("log_err_p"), "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                 MessageBox.Show(Global.GetString("log_err"), "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
    }
}
