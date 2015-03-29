using eRacunalniServis.Forms.Dobavljaci;
using eRacunalniServis_Servis.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis.Forms.Proizvodi
{
    public partial class frmNabavaProizvoda : Form
    {
        private eRacunalniServis_Servis.Data.Dobavljaci dobavljac;
        public frmNabavaProizvoda()
        {
            InitializeComponent();
        }

        private void btnOdaberiDobavljaca_Click(object sender, EventArgs e)
        {
            frmPretragaDobavljaca form = new frmPretragaDobavljaca();
            form.ShowDialog();

            if (form.dobavljac != null)
            {
                dobavljac = form.dobavljac;
                txtbNaziv.Text = dobavljac.Naziv;
                txtbKontaktOsoba.Text = dobavljac.KontaktOsoba;
                txtbTelefon.Text = dobavljac.Telefon;
            }
        }

        private void frmNabavaProizvoda_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }

        private void BindSkladista()
        {
            cmbSkladista.DataSource = DASkladista.SelectAll();
            cmbSkladista.DisplayMember = "Naziv";
            cmbSkladista.ValueMember = "SkladisteID";
        }
    }
}
