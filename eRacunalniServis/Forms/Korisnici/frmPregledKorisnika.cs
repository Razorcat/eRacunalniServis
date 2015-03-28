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
using eRacunalniServis.Forms.Korisnici;

namespace eRacunalniServis_Servis.Forms
{
    public partial class frmPregledKorisnika : Form
    {
        private Korisnici korisnik;       
        public frmPregledKorisnika()
        {
            InitializeComponent();
        }

        private void txtbPretragaByImeP_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dGVKorisnici.DataSource = DAKorisnici.SelectByName(txtbPretragaByImeP.Text);
            dGVKorisnici.Columns[0].Visible = false;
            dGVKorisnici.ClearSelection();
        }

        private void frmPregledKorisnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeaktiviraj_Click(object sender, EventArgs e)
        {            
            if (korisnik != null)
            {                
                if (korisnik.KorisnikID != Global.prijavljeniKorisnik.KorisnikID)
                {
                    if (korisnik.Status == true)
                    {
                        DAKorisnici.UpdateStatus(korisnik.KorisnikID, false);                       
                        BindGrid();                       
                    }
                    else if (korisnik.Status == false)
                    {
                        DAKorisnici.UpdateStatus(korisnik.KorisnikID, true);                       
                        BindGrid();                       
                    }                    
                }
            }
            BindGrid(); 
        }

        private void dGVKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            int korisnikID = Convert.ToInt32( dGVKorisnici.SelectedRows[0].Cells[0].Value);
            korisnik =  DAKorisnici.SelectByID(korisnikID);
        }

        private void osobniPodaciMenu_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                frmDodajKorisnika updateForm = new frmDodajKorisnika(korisnik,this.Font);
                updateForm.MaximizeBox = false;
                updateForm.ShowDialog();
                BindGrid();
            }
        }

        private void statusniPodaciMenu_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                frmPristup pristupForm = new frmPristup(korisnik,this.Font);
                pristupForm.MaximizeBox = false;
                pristupForm.ShowDialog();
                BindGrid();
            }
        }
    }
}
