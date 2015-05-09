using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using eRacunalniServis_Servis.Data;
using eRacunalniServis_Servis.Util;

namespace eRacunalniServis_Web.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        

        protected void on_btnRegistriraj_Click(object sender, EventArgs e)
        {
            if (txtbLozinka.Text.Length > 5)
            {
                Kupci kupac = new Kupci();
                kupac.Ime = txtbIme.Text.Trim();
                kupac.Prezime = txtbPrezime.Text.Trim();
                kupac.Email = txtbEmail.Text;
                kupac.KorisnickoIme = txtbKorisnickoIme.Text.Trim();

                kupac.LozinkaSalt = UIHelper.GenerateSalt();
                kupac.LozinkaHash = UIHelper.GenerateHash(txtbLozinka.Text.Trim(), kupac.LozinkaSalt);

                kupac.Status = true;

                DAKupci.Insert(kupac);
                OcistiPolja();
            }
        }

        private void OcistiPolja()
        {
            txtbIme.Text = "";
            txtbPrezime.Text = "";
            txtbEmail.Text = "";
            txtbKorisnickoIme.Text = "";
            txtbLozinka.Text = "";
            txtbLozinkaPotvrda.Text = "";
        }

        
    }
}