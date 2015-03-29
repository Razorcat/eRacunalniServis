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

namespace eRacunalniServis.Forms.Dobavljaci
{
    public partial class frmPretragaDobavljaca : Form
    {        
        public eRacunalniServis_Servis.Data.Dobavljaci dobavljac { get; set; }
        public frmPretragaDobavljaca()
        {           
            InitializeComponent();
        }

        private void frmPretragaDobavljaca_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgvDobavljaci.AutoGenerateColumns = false;
            dgvDobavljaci.DataSource = DADobavljaci.SelectByNaziv(txtbDobavljacNaziv.Text);           
            dgvDobavljaci.ClearSelection();
        }

        private void txtbDobavljacNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvDobavljaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dobavljacId = Convert.ToInt32(dgvDobavljaci.SelectedRows[0].Cells[0].Value);
                if (dobavljacId > 0)
                {
                    dobavljac = DADobavljaci.SelectById(dobavljacId);
                    this.Close();
                }
            }
        }
    }
}
