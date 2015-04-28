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
using eRacunalniServis_Servis.Data;

namespace eRacunalniServis.Forms.Prodaja
{
    public partial class frmNovaProdaja : Form
    {
        eRacunalniServis_Servis.Data.Kupci kupac;
        public frmNovaProdaja()
        {
            InitializeComponent();
        }

        private void btnOdaberiKupca_Click(object sender, EventArgs e)
        {
            frmPregledKupaca frmPK = new frmPregledKupaca();
            frmPK.ShowDialog();
            if (frmPK.kupac != null)
            {
                kupac = frmPK.kupac;
                txtbIme.Text = kupac.Ime;
                txtbPrezime.Text = kupac.Prezime;
            }
        }
    }
}
