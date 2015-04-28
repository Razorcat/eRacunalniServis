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

namespace eRacunalniServis.Forms.Kupci
{
    public partial class frmAdministracijaKupaca : Form
    {
        private eRacunalniServis_Servis.Data.Kupci kupac;
        public frmAdministracijaKupaca()
        {
            InitializeComponent();
            BingGrid();
        }
        private void BingGrid()
        {
            dgvKupci.ClearSelection();
            dgvKupci.DataSource = DAKupci.SelectByName(txtbNaziv.Text);
            dgvKupci.Columns[0].Visible = false;
            dgvKupci.Columns[6].Visible = false;
            dgvKupci.Columns[7].Visible = false;
            dgvKupci.Columns[9].Visible = false;
            dgvKupci.Columns[10].Visible = false;
            dgvKupci.Columns[11].Visible = false;
            dgvKupci.ClearSelection();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKupci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kupacID = Convert.ToInt32(dgvKupci.SelectedRows[0].Cells[0].Value);
            kupac = DAKupci.SelectById(kupacID);            
        }

        private void btnPromjeniStatus_Click(object sender, EventArgs e)
        {
            if (kupac != null)
            {
                if (kupac.Status == true)
                {
                    DAKupci.UpdateStatus(kupac.KupacID, false);
                    kupac.Status = false;
                    BingGrid();
                }
                else if (kupac.Status == false)
                {
                    DAKupci.UpdateStatus(kupac.KupacID, true);
                    kupac.Status = true;
                    BingGrid();
                }
            }
        }

        private void btnPromjeniPodatke_Click(object sender, EventArgs e)
        {
            if (kupac != null)
            {
                frmKupciIzmjene KI = new frmKupciIzmjene(kupac);
                KI.ShowDialog();
            }
        }
    }
}
