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
        List<IzlazStavke> izlazStavke = new List<IzlazStavke>();       

        private decimal iznos = 0;   
        private int proizvodID=0;

        public frmNovaProdaja()
        {
            InitializeComponent();
            BindGridProizvodi();
            txtbIznos.Text = Math.Round(iznos, 2).ToString();   
        }

        private void btnOdaberiKupca_Click(object sender, EventArgs e)
        {
            frmPregledKupaca frmPK = new frmPregledKupaca();
            frmPK.ShowDialog();
            if (frmPK.kupac != null)
            {
                kupac = new eRacunalniServis_Servis.Data.Kupci();
                kupac = frmPK.kupac;
                txtbIme.Text = kupac.Ime;
                txtbPrezime.Text = kupac.Prezime;
            }
        }

        private void txtbSifra_TextChanged(object sender, EventArgs e)
        {
            BindGridProizvodi();
        }

        private void BindGridProizvodi()
        {
            dgvProizvodi.DataSource = DAProizvodi.SelectBySifraNazivList(txtbSifra.Text, txtbNaziv.Text);
            dgvProizvodi.Columns[0].Visible = false;
            dgvProizvodi.ClearSelection();
        }

        private void txtbNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGridProizvodi();
        }

        private void btnDodajP_Click(object sender, EventArgs e)
        {
            eRacunalniServis_Servis.Data.Proizvodi proizvod = new eRacunalniServis_Servis.Data.Proizvodi();
            IzlazStavke iStavka = new IzlazStavke();
            if (DAProizvodi.SelectById(proizvodID) != null)
            {
                proizvod = DAProizvodi.SelectById(proizvodID);
                iStavka.Proizvodi = proizvod;
                iStavka.Cijena = Math.Round(proizvod.Cijena * (1 - ntxtbPopust.Value / 100), 2);
                iStavka.Popust = Math.Round(proizvod.Cijena * (ntxtbPopust.Value / 100), 2);
                iStavka.Kolicina = Convert.ToInt32(ntxtbKolicina.Value);

                iznos += proizvod.Cijena * iStavka.Kolicina;

                izlazStavke.Add(iStavka);

                BindGridProdaja();
                txtbIznos.Text = Math.Round(iznos, 2).ToString();
            }
        }

        private void BindGridProdaja()
        {
            dgvProdaja.ClearSelection();
           // dgvProdaja.AutoGenerateColumns = false;
            dgvProdaja.DataSource = null;            

            dgvProdaja.DataSource = izlazStavke;
            dgvProdaja.Columns[0].Visible = false;
            dgvProdaja.Columns[1].Visible = false;
            dgvProdaja.Columns[2].Visible = false;
            dgvProdaja.Columns[6].Visible = false;
            dgvProdaja.ClearSelection();
        }

        private void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proizvodID = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);
        }

        private void btnBrisiStavku_Click(object sender, EventArgs e)
        {
            iznos -= izlazStavke[dgvProdaja.CurrentCell.RowIndex].Proizvodi.Cijena * izlazStavke[dgvProdaja.CurrentCell.RowIndex].Kolicina;
            izlazStavke.RemoveAt(dgvProdaja.CurrentCell.RowIndex);            
            BindGridProdaja();
            txtbIznos.Text = Math.Round(iznos, 2).ToString();
        }

        private void btnZakljuciProdaju_Click(object sender, EventArgs e)
        {
            Izlazi izlaz = new Izlazi();
            izlaz.KorisnikID = eRacunalniServis_Servis.Global.prijavljeniKorisnik.KorisnikID;
        }

        private void btnNoviKupac_Click(object sender, EventArgs e)
        {
            eRacunalniServis.Forms.Kupci.frmDodajKupca dk = new Kupci.frmDodajKupca();
            dk.ShowDialog();            
        }
        
    }
}
