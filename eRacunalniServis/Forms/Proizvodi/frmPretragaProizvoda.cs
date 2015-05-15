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
        eRacunalniServis_Servis.Data.Proizvodi proizvod;
        public frmPretragaProizvoda()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvProizvodi.ClearSelection();
            dgvProizvodi.DataSource = DAProizvodi.SelectBySifraNazivList(txtSifra.Text, txtNaziv.Text);
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

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (proizvod!=null)
            {
                if (proizvod.Status == true)
                {
                    DAProizvodi.UpdateStatus(proizvod.ProizvodID, false);
                    proizvod.Status = false;
                    BindGrid();
                }
                else if (proizvod.Status == false)
                {
                    DAProizvodi.UpdateStatus(proizvod.ProizvodID, true);
                    proizvod.Status = true;
                    BindGrid();
                }
            }
        }

        private void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int proizvodID = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);
           proizvod = DAProizvodi.SelectById(proizvodID);
        }
    }
}
