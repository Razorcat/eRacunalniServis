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
    public partial class frmStanjeSkladista : Form
    {
        public frmStanjeSkladista()
        {
            InitializeComponent();           
        }

        private void BindSkladista()
        {
            cmbSkladisteList.DataSource = DASkladista.SelectAll();
            cmbSkladisteList.DisplayMember = "Naziv";
            cmbSkladisteList.ValueMember = "SkladisteID";
        }

        private void skladisteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSkladisteList.SelectedIndex != 0)
            {
                int skladisteId = Convert.ToInt32(cmbSkladisteList.SelectedValue);
                dgvSkladisteProizvodi.DataSource = DASkladista.GetStanjeSkladista(skladisteId);
                dgvSkladisteProizvodi.Columns[0].Visible = false;
                dgvSkladisteProizvodi.ClearSelection();
            }
            else
                dgvSkladisteProizvodi.DataSource = null;
        }

        private void frmStanjeSkladista_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }
    }
}
