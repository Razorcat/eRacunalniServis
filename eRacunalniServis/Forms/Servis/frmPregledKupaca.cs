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
    public partial class frmPregledKupaca : Form
    {
        public Kupci kupac;
        public frmPregledKupaca()
        {
            InitializeComponent();
            BingGrid();
        }

        private void txtbNaziv_TextChanged(object sender, EventArgs e)
        {
            BingGrid();
        }

        private void BingGrid()
        {
            dgvKupci.ClearSelection();
            dgvKupci.DataSource = DAKupci.SelectByName(txtbNaziv.Text);
            dgvKupci.Columns[0].Visible = false;
            dgvKupci.Columns[6].Visible = false;
            dgvKupci.Columns[7].Visible = false;
            dgvKupci.Columns[8].Visible = false;
            dgvKupci.Columns[9].Visible = false;
            dgvKupci.ClearSelection();
        }

        private void dgvKupci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int kupacId = Convert.ToInt32(dgvKupci.SelectedRows[0].Cells[0].Value);
                if (kupacId > 0)
                {
                    kupac = DAKupci.SelectById(kupacId);
                    this.Close();
                }
            }
        }
    }
}
