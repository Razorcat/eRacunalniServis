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
    public partial class frmPretragaProizvoda : Form
    {
        public frmPretragaProizvoda()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvProizvodi.ClearSelection();
            dgvProizvodi.DataSource = DAProizvodi.SelectBySifraNaziv(txtSifra.Text, txtNaziv.Text);
            dgvProizvodi.Columns[0].Visible = false;
            dgvProizvodi.ClearSelection();
        }

        private void frmPretragaProizvoda_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
