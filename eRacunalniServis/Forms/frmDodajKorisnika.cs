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
using eProdaja_Service.Util;

namespace eProdaja.Forms
{
    public partial class frmDodajKorisnika : Form
    {
        public frmDodajKorisnika()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Korisnici k = new Korisnici();
            k.Ime = txtbIme.Text.Trim();
            k.Prezime = txtbPrezime.Text;
            k.Email = txtbEmail.Text.Trim();
            k.Telefon = mtxtbTelefon.Text;
            k.KorisnickoIme = txtbKorisnickoIme.Text.Trim();

            k.LozinkaSalt = UIHelper.GenerateSalt();
            k.LozinkaHash = UIHelper.GenerateHash(txtbLozinka.Text, k.LozinkaSalt);

            List<Uloge> uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

            DAKorisnici.InsertKorisnik(k, uloge);

            MessageBox.Show(Global.GetString("usr_succ"));
            IsprazniPolja();
            this.Close();
        }
        private void IsprazniPolja() {
            txtbIme.Text = "";
            txtbPrezime.Text = "";
        }

        private void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            ((ListBox)ulogeList).DataSource=DAKorisnici.UlogeSelect();
            ((ListBox)ulogeList).DisplayMember = "Naziv";
        }
        
        
    }
}
