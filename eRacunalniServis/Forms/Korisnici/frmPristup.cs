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
using eRacunalniServis_Servis;


namespace eRacunalniServis.Forms.Korisnici
{
    public partial class frmPristup : Form
    {
        private eRacunalniServis_Servis.Data.Korisnici korisnik;
        public frmPristup(eRacunalniServis_Servis.Data.Korisnici k,Font font)
        {
            this.Font = font;
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            if (k != null)
            {
                korisnik = k;
                ucitajPodatke();
            }
            this.Text = "Izmjena pristupnih podataka";
        }
        void ucitajPodatke() {
            txtbKorisnickoIme.Text = korisnik.KorisnickoIme;
            chbAkitivan.Checked = korisnik.Status;
            ((ListBox)UlogeList).DataSource = DAKorisnici.UlogeSelect();
            ((ListBox)UlogeList).DisplayMember = "Naziv";
            UlogeList.ClearSelected();

            korisnik.Uloge = DAKorisnici.SelectUloge(korisnik.KorisnikID);

            for (int i = 0; i < UlogeList.Items.Count; i++) {
                if (korisnik.Uloge.Contains(UlogeList.Items[i])) {
                    UlogeList.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }        

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                bool err = false;
                if (txtbLozinka.Text != "" && txtbPotvrdaLozinke.Text != "")
                {
                    if (txtbLozinka.Text == txtbPotvrdaLozinke.Text)
                    {
                        korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                        korisnik.LozinkaHash = UIHelper.GenerateHash(txtbPotvrdaLozinke.Text, korisnik.LozinkaSalt);
                        DAKorisnici.ResetPassword(korisnik);
                    }
                    else
                    {
                        err = true;
                        MessageBox.Show(Global.GetString("err_pass_ns"), "Izmjene korisničkih podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else err = true;
                DAKorisnici.UpdateUloge(korisnik.KorisnikID, UlogeList.CheckedItems.Cast<Uloge>().ToList());
                if (err != true)
                {
                    string Poruka = "";
                    if (korisnik.KorisnikID == Global.prijavljeniKorisnik.KorisnikID && !chbAkitivan.Checked)
                        Poruka = Global.GetString("status_err");
                    else if (korisnik.Status != chbAkitivan.Checked)
                    {
                        DAKorisnici.UpdateStatus(korisnik.KorisnikID, chbAkitivan.Checked);
                    }
                    MessageBox.Show(Poruka + "\n" + Global.GetString("usr_succ_upd"), "Izmjene korisničkih podataka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtbLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (txtbLozinka.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtbLozinka, Global.GetString("pass_err"));
            }
        }

        private void txtbPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {
            if (txtbPotvrdaLozinke.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtbPotvrdaLozinke, Global.GetString("pass_err"));
            }
        }

        private void UlogeList_Validating(object sender, CancelEventArgs e)
        {
            if (UlogeList.CheckedItems.Count < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(UlogeList, Global.GetString("uloge_req"));
            }
        }
    }
}
