using eRacunalniServis.Forms.Dobavljaci;
using eRacunalniServis_Servis;
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
        private List<UlazStavke> stavke = new List<UlazStavke>();
        private decimal iznos = 0;
        private decimal pdv = 0;

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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajStavku();
            BindGrid();
        }

        private void BindGrid()
        {
            stavkeGrid.ClearSelection();
            stavkeGrid.AutoGenerateColumns = false;
            stavkeGrid.DataSource = null;
            stavkeGrid.DataSource = stavke;           
            stavkeGrid.ClearSelection();      
        }

        private void DodajStavku()
        {
            try
            {
                UlazStavke s = new UlazStavke();
                //Ovdje je iskorištena već kreirana procedura za pretragu proizvoda po šifri i nazivu
                //Dovoljno je proslijediti unesenu šifru i prazan string za naziv proizvoda

                s.ProizvodID = DAProizvodi.SelectBySifraNazivList(txtbSifraProizvoda.Text, "")[0].ProizvodID;

                //Kako bi se u gridu mogle prikazati dodatne informacije (npr. naziv) 
                //učitava se objekat Proizvodi u okviru nove stavke
                //U klasi Proizvodi je preklopljena funkcija ToString() za prikaz šifre i naziva
                s.Proizvodi = DAProizvodi.SelectById(s.ProizvodID);
                s.Kolicina = Convert.ToInt32(mtxtbKolicina.Text);
                s.Cijena = Convert.ToDecimal(mtxtbCijena.Text);
                stavke.Add(s);
                iznos += s.Kolicina * s.Cijena;
                //Stopu PDV-a prebaciti u config file
                pdv = (decimal)0.17 * iznos;
                //Na formi prikazati ukupan iznos računa sa pdv-om
                txtbIznosRacuna.Text = Math.Round(iznos + pdv, 2).ToString();
                txtbPDV.Text = Math.Round(pdv, 2).ToString();

                txtbSifraProizvoda.Text = "";
                mtxtbKolicina.Text = "000";
                mtxtbCijena.Text = "000000";
                txtbSifraProizvoda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            try
            {
                Ulazi ulaz = new Ulazi();
                ulaz.DobavljacID = dobavljac.DobavljacID;
                ulaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                if (cmbSkladista.SelectedIndex != 0)
                    ulaz.SkladisteID = Convert.ToInt32(cmbSkladista.SelectedValue);
                ulaz.BrojFakture = txtbBrojFakture.Text;
                ulaz.Datum = dtpDatum.Value;
                ulaz.Napomena = rtxtbNapomena.Text;
                ulaz.IznosRacuna = iznos + pdv;
                ulaz.PDV = pdv;

                DAProizvodi.InsertNabavka(ulaz, stavke);
                MessageBox.Show(Global.GetString("Uspješno ste nabavili proizvode!"), "Nabavka robe", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPregledProizvoda_Click(object sender, EventArgs e)
        {
            frmPretragaProizvoda PP = new frmPretragaProizvoda();
            PP.Show();
        }
    }
}
