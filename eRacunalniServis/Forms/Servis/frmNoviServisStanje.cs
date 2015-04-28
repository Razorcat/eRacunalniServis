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
    public partial class frmNoviServisStanje : Form
    {
        int ServisId;
        Servisi servis;
        public frmNoviServisStanje(int servisID)
        {
            InitializeComponent();            
            ServisId = servisID;
            servis = DAServisi.GetById(ServisId);
            if (servis != null) {
                txtbNaziv.Text = servis.Naziv;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (rtxtbOpis.TextLength > 5)
            {
                DAServisStanje.Insert(ServisId, rtxtbOpis.Text);
                MessageBox.Show("Uspješno ste dodali novi zapis", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
