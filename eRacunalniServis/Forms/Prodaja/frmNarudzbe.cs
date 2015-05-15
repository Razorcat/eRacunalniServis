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
    public partial class frmNarudzbe : Form
    {
        private int narudzbaID = 0;

        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private void btnZatvoriProzor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNarudzbe_Load(object sender, EventArgs e)
        {
            dgvNarudzbe.DataSource = DANarudzbe.GetAktivneNarudzbe();
            
            dgvNarudzbe.Columns[0].Visible = false;
            dgvNarudzbe.Columns[2].Visible = false;
        }

        private void dgvNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            narudzbaID = Convert.ToInt32(dgvNarudzbe.SelectedRows[0].Cells[0].Value);
        }

        private void btnPromjeniStatus_Click(object sender, EventArgs e)
        {
            if(narudzbaID>0)
                DANarudzbe.UpdateStatus(narudzbaID, true);
        }
    }
}
