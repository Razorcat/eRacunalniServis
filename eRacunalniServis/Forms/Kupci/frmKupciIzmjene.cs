using eRacunalniServis_Servis.Data;
using eRacunalniServis_Servis.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis.Forms.Kupci
{
    public partial class frmKupciIzmjene : Form
    {
        private eRacunalniServis_Servis.Data.Kupci kupacIzmjene;
        public frmKupciIzmjene(eRacunalniServis_Servis.Data.Kupci kupac)
        {
            InitializeComponent();
            if (kupac != null)
            {
                kupacIzmjene = kupac;
                PopuniPolja();
            }
        }

        private void PopuniPolja()
        {
            txtbIme.Text = kupacIzmjene.Ime;
            txtbPrezime.Text = kupacIzmjene.Prezime;
            txtbEmail.Text = kupacIzmjene.Email;
            txtbKorisnickoIme.Text = kupacIzmjene.KorisnickoIme;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (kupacIzmjene != null) {
                if (txtbLozinka.Text.Equals(txtbPotvrdaL.Text))
                {
                    kupacIzmjene.Ime = txtbIme.Text;
                    kupacIzmjene.Prezime = txtbPrezime.Text;
                    kupacIzmjene.Email = txtbEmail.Text;
                    kupacIzmjene.KorisnickoIme = txtbKorisnickoIme.Text;

                    kupacIzmjene.LozinkaSalt = UIHelper.GenerateSalt();
                    kupacIzmjene.LozinkaHash = UIHelper.GenerateHash(txtbLozinka.Text, kupacIzmjene.LozinkaSalt);

                    DAKupci.UpdatePodatke(kupacIzmjene);

                    MessageBox.Show("Uspješno ste izmjenili podatke kupcu!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Niste potvrdili lozinku!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
            
        }

    }
}
