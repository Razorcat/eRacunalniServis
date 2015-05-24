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

namespace eRacunalniServis.Forms.Servis
{
    public partial class frmPregledServisa : Form
    {
        private int servisID;
        private eRacunalniServis_Servis.Data.Kupci kupac;
        public frmPregledServisa()
        {
            InitializeComponent();
            BingGridS();
        }

        private void BingGridS()
        {
            dgvServisi.ClearSelection();
            dgvServisi.DataSource = DAServisi.GetAll();
            dgvServisi.Columns[0].Visible = false;
            dgvServisi.Columns[1].Visible = false;
            dgvServisi.Columns[7].Visible = false;
            dgvServisi.Columns[6].Visible = false;  
        }
       private void BingGridSS(int id){
            dgvServisiStanja.ClearSelection();
            dgvServisiStanja.DataSource = DAServisStanje.GetAllById(id);
            dgvServisiStanja.Columns[0].Visible = false;
            dgvServisiStanja.Columns[1].Visible = false;
            dgvServisiStanja.Columns[4].Visible = false;  
        }

        private void dgvServisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            servisID = Convert.ToInt32(dgvServisi.SelectedRows[0].Cells[0].Value);
            if (Convert.ToInt32(dgvServisi.SelectedRows[0].Cells[1].Value) > 0)
            {
                kupac = DAKupci.SelectById(Convert.ToInt32(dgvServisi.SelectedRows[0].Cells[1].Value));
                txtbKupac.Text = kupac.Ime + " " + kupac.Prezime;
            }
            BingGridSS(servisID);
        }

        private void BtnDodajNoviZapis_Click(object sender, EventArgs e)
        {
            frmNoviServisStanje NSS = new frmNoviServisStanje(servisID);
            NSS.ShowDialog();
        }

        private void btnPromjeniStanje_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==MessageBox.Show("Da li želite stavi popravljeno?", "Popravljeno?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) {
                DAServisi.UpdatePopravljeno(servisID,true);
                BingGridS();
            }
        }
    }
}
