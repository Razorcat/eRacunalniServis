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
    public partial class frmAdministracijaDobavljaca : Form
    {
        eRacunalniServis_Servis.Data.Dobavljaci dobavljac;
        public frmAdministracijaDobavljaca()
        {            
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {            
            dgvDobavljaci.DataSource = DADobavljaci.SelectByNazivAll(txtbDobavljacNaziv.Text);
            dgvDobavljaci.Columns[0].Visible = false;
            dgvDobavljaci.Columns[11].Visible = false;
            dgvDobavljaci.ClearSelection();
        }

        private void dgvDobavljaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dobavljacId = Convert.ToInt32(dgvDobavljaci.SelectedRows[0].Cells[0].Value);
            dobavljac = DADobavljaci.SelectById(dobavljacId);
        }

        private void txtbDobavljacNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPromjeniStatus_Click(object sender, EventArgs e)
        {
            if (dobavljac != null)
            {               
                    if (dobavljac.Status == true)
                    {
                        DADobavljaci.UpdateStatus(dobavljac.DobavljacID,false);
                        dobavljac.Status = false;
                        BindGrid();
                    }
                    else if (dobavljac.Status == false)
                    {
                        DADobavljaci.UpdateStatus(dobavljac.DobavljacID,true);
                        dobavljac.Status = true;
                        BindGrid();
                    }
                    MessageBox.Show("Uspješno ste promijeni status!", "Promjena stutusa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                     
        }
        
    }
}
