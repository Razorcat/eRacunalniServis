using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRacunalniServis_Servis.Util;
using QRCoder;
using eRacunalniServis_Servis.Data;
using System.IO;

namespace eRacunalniServis.Forms.Servis
{
    public partial class frmNoviServis : Form
    {
        private Kupci kupac;        
        public frmNoviServis()
        {
            InitializeComponent();
            GenerateQRCode();
        }
        private void GenerateQRCode() {            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(DAServisi.GetLastID().ToString()+"1..1", QRCodeGenerator.ECCLevel.M);
            pbQRcode.BackgroundImage = qrCode.GetGraphic(20);
        }

        private void btnGenerirajBC_Click(object sender, EventArgs e)
        {
            GenerateQRCode();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {            
            byte[] QRc;
            MemoryStream ms;
            if (kupac != null)
            {
                ms = new MemoryStream();
                

                pbQRcode.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                QRc = ms.ToArray();

                DAServisi.Insert(txtbNaziv.Text, kupac.KupacID, QRc,rtxbOpis.Text);                

                this.Close();
            }
        }

        private void btnOdaberiKupca_Click(object sender, EventArgs e)
        {
            frmPregledKupaca frmPK = new frmPregledKupaca();
            frmPK.ShowDialog();
            if (frmPK.kupac != null)
            {
                kupac = frmPK.kupac;
                txtbKupac.Text = kupac.Ime + " " + kupac.Prezime;                
            }
        }
    }
}
