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
using eRacunalniServis_Servis.Util;

namespace eRacunalniServis.Forms.Kupci
{
    public partial class frmDodajKupca : Form
    {
        private eRacunalniServis_Servis.Data.Kupci kupac;
        public frmDodajKupca()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtbIme.Text != "" && txtbPrezime.Text != "" && txtbEmail.Text != "" && txtbKorisnickoIme.Text != "" && txtbLozinka.Text != "" && txtbPotvrdaL.Text != "") { }
                if(lblLozinka.Text==lblPotvrdaL.Text){
                    kupac = new eRacunalniServis_Servis.Data.Kupci();

                    kupac.Ime = txtbIme.Text;
                    kupac.Prezime = txtbPrezime.Text;
                    kupac.Email = txtbEmail.Text;
                    kupac.Status = chckbAktivan.Checked;
                    kupac.KorisnickoIme = txtbKorisnickoIme.Text;
                    kupac.LozinkaSalt = UIHelper.GenerateSalt();
                    kupac.LozinkaHash = UIHelper.GenerateHash(txtbLozinka.Text, kupac.LozinkaSalt);

                    DAKupci.Insert(kupac);
                    
                    MessageBox.Show("Uspješno ste dodali novog kupca!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsprazniPolja();
                    this.Close();
                }
          }

        private void IsprazniPolja()
        {
 	        txtbIme.Text = ""; 
            txtbPrezime.Text = "";
            txtbEmail.Text = "";
            txtbKorisnickoIme.Text = "";
            txtbLozinka.Text = "" ;
            txtbPotvrdaL.Text = "";
            txtbEmail.Text="";
        }        
    }
}
