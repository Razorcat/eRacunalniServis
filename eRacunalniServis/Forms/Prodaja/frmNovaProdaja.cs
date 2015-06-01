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
        List<IzlazStavke> izlazStavke = new List<IzlazStavke>();       

        private decimal iznos = 0;
        private decimal iznosPDV = 0;   

        private int proizvodID=0;
        private int skladisteId=1;
        private bool dgPKlik = false;
        private bool dgPrKlik = false;
        private int dostupnoK = 0;

        public frmNovaProdaja()
        {
            InitializeComponent();
            BindGridProizvodi();
            txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
            txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";
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
            if (dgPrKlik == true && mtxtbCijena.MaskFull)
            {
                eRacunalniServis_Servis.Data.Proizvodi proizvod = new eRacunalniServis_Servis.Data.Proizvodi();
                IzlazStavke iStavka = new IzlazStavke();
                if (DAProizvodi.SelectById(proizvodID) != null)
                {
                    proizvod = DAProizvodi.SelectById(proizvodID);
                    if (ntxtbKolicina.Value <= dostupnoK)
                    {
                        iStavka.Proizvodi = proizvod;
                        iStavka.ProizvodID = proizvod.ProizvodID;
                        iStavka.Cijena = Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (1 - ntxtbPopust.Value / 100), 2);
                        iStavka.Popust = Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (ntxtbPopust.Value / 100), 2);
                        iStavka.Kolicina = Convert.ToInt32(ntxtbKolicina.Value);

                        iznos += iStavka.Cijena * iStavka.Kolicina;
                        iznosPDV = iznos * (decimal)1.17;

                        izlazStavke.Add(iStavka);

                        BindGridProdaja();
                        txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
                        txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";

                        dostupnoK -= Convert.ToInt32( ntxtbKolicina.Value);
                        txtStanjeNaSkladistu.Text = dostupnoK + " kom";
                    }
                }
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
            dgPrKlik = true;

            eRacunalniServis_Servis.Data.Proizvodi proizvod = new eRacunalniServis_Servis.Data.Proizvodi();
            proizvod = DAProizvodi.SelectById(proizvodID);
            if (proizvod.UlazStavke.ToList().Count > 0)
            {
                dostupnoK = proizvod.UlazStavke.ToList().First().Kolicina;
                txtStanjeNaSkladistu.Text = dostupnoK+ " kom";
            }
            else
            {
                txtStanjeNaSkladistu.Text = dostupnoK + " kom";
                dostupnoK = 0;
            }
        }

        private void btnBrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgPKlik==true && izlazStavke.Count>0)
            {
                iznos -= izlazStavke[dgvProdaja.CurrentCell.RowIndex].Proizvodi.Cijena * izlazStavke[dgvProdaja.CurrentCell.RowIndex].Kolicina;
                izlazStavke.RemoveAt(dgvProdaja.CurrentCell.RowIndex);
                iznosPDV = iznos * (decimal)1.17;
                BindGridProdaja();
                txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
                txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";
            }
        }

        private void btnZakljuciProdaju_Click(object sender, EventArgs e)
        {
            if (skladisteId > 0 && txtbBrRacuna.Text!="")
            {
                Izlazi izlaz = new Izlazi();
                izlaz.BrojRacuna = txtbBrRacuna.Text;
                izlaz.KorisnikID = eRacunalniServis_Servis.Global.prijavljeniKorisnik.KorisnikID;
                izlaz.Korisnici = eRacunalniServis_Servis.Global.prijavljeniKorisnik;
                izlaz.Zakljucen = false;
                izlaz.IznosBezPDV = iznos;
                izlaz.IznosSaPDV = iznosPDV;
                izlaz.SkladisteID = skladisteId;
                //insert izlaz u bazu
                //insert zlaz stavka
                izlaz.KorisnikID = eRacunalniServis_Servis.Global.prijavljeniKorisnik.KorisnikID;

                DAProizvodi.InsertProdaju(izlaz, izlazStavke);
                foreach (IzlazStavke IzS in izlazStavke)
                {
                    //IzS.Kolicina;
                    //IzS.ProizvodID
                    //smanji kolicinu na skladistu
                }

                MessageBox.Show("Uspješno ste zaključili prodaju", "Prodaja info", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                this.Close();
            }
        }

        private void btnNoviKupac_Click(object sender, EventArgs e)
        {
            eRacunalniServis.Forms.Kupci.frmDodajKupca dk = new Kupci.frmDodajKupca();
            dk.ShowDialog();            
        }

        private void dgvProdaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgPKlik = true;
        }

        private void frmNovaProdaja_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }
        private void BindSkladista()
        {
            cmbSkladisteList.DataSource = DASkladista.SelectAll();
            cmbSkladisteList.DisplayMember = "Naziv";
            cmbSkladisteList.ValueMember = "SkladisteID";
        }

        private void cmbSkladisteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSkladisteList.SelectedIndex != 0)            
                 skladisteId = Convert.ToInt32(cmbSkladisteList.SelectedValue);
        }       

        
    }
}
