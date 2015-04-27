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
        public frmPregledServisa()
        {
            InitializeComponent();
            BingGrid();
        }

        private void BingGrid()
        {
            dgvServisi.ClearSelection();
            dgvServisi.DataSource = DAServisi.GetAll();
            dgvServisi.Columns[0].Visible = false;   
        }
    }
}
