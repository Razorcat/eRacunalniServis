using eRacunalniServis_Servis.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis_Servis.Forms
{
    public partial class frmDodajProizvod : Form
    {
        Proizvodi proizvod;
        public frmDodajProizvod()
        {
            InitializeComponent();
           
        }

        private void frmDodajProizvod_Load(object sender, EventArgs e)
        {
            BindVrste();
            BindJediniceMjere();
        }

        private void BindJediniceMjere()
        {
            cmbJedinicaMjere.DataSource = DAProizvodi.JediniceMjereSelectAll();
            cmbJedinicaMjere.DisplayMember = "Naziv";
            cmbJedinicaMjere.ValueMember = "JedinicaMjereID";
        }

        private void BindVrste()
        {
            cmbVrste.DataSource = DAProizvodi.VrsteProizvodaSelectAll();
            cmbVrste.DisplayMember = "Naziv";
            cmbVrste.ValueMember = "VrstaID";
        }

        private void cmbVrste_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            if (cmbVrste.SelectedIndex == 0)
                dgvProizvodi.DataSource = null;
            else
            {
                dgvProizvodi.ClearSelection();
                dgvProizvodi.DataSource = DAProizvodi.SelectByVrsta(Convert.ToInt32(cmbVrste.SelectedValue));
                dgvProizvodi.Columns[0].Visible = false;
            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            if(proizvod==null)
                proizvod = new Proizvodi();
            if (cmbVrste.SelectedIndex != 0)
                proizvod.VrstaID = Convert.ToInt32(cmbVrste.SelectedValue);
            if (cmbJedinicaMjere.SelectedIndex != 0)
                proizvod.JedinicaMjereID = Convert.ToInt32(cmbJedinicaMjere.SelectedValue);

            proizvod.Naziv = txtbNaziv.Text.Trim();
            proizvod.Sifra = txtbSifraProizvoda.Text.Trim();
            proizvod.Cijena = Convert.ToDecimal(mtxtCijena.Text);           

            DAProizvodi.Insert(proizvod);
            BindGrid();
            //OcistiPolja();
        }

        private void btnDodajS_Click(object sender, EventArgs e)
        {
            proizvod = new Proizvodi();
            MemoryStream ms;

            if (pictureBoxProizvod.Image != null)
                pictureBoxProizvod.Image.Dispose();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            openFileDialog.ShowDialog();
            txtbSlika.Text = openFileDialog.FileName;

            Image image;
            try
            {
                image = Image.FromFile(openFileDialog.FileName);
            }
            catch (Exception)
            {
                image = null;
            }

            Image rezisedImage;
            Image croppedImage;
            if (image != null)
            {

                rezisedImage = Util.UIHelper.ResizeImage(image, new Size(200, 180));
                croppedImage = Util.UIHelper.CropImage(rezisedImage, new Rectangle(40, 40, 120, 100));

                ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                proizvod.Slika = ms.ToArray();

                ms = new MemoryStream();
                croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                proizvod.SlikaThumb = ms.ToArray();

                pictureBoxProizvod.Image = croppedImage;
            }
        }
              
    }
}
