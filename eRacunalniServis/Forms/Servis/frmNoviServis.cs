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
using System.Drawing.Printing;

namespace eRacunalniServis.Forms.Servis
{
    public partial class frmNoviServis : Form
    {
        private eRacunalniServis_Servis.Data.Kupci kupac;        
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();

            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;            

            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
                myPrintDocument1.Print();            
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pbQRcode.Width, pbQRcode.Height);
            pbQRcode.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pbQRcode.Width, pbQRcode.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }

    }
}
