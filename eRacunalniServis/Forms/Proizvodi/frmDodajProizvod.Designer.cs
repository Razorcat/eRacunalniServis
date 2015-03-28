namespace eRacunalniServis_Servis.Forms
{
    partial class frmDodajProizvod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblSifraProizvoda = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblJedinicaMjere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajS = new System.Windows.Forms.Button();
            this.cmbVrste = new System.Windows.Forms.ComboBox();
            this.txtbSifraProizvoda = new System.Windows.Forms.TextBox();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.txtbSlika = new System.Windows.Forms.TextBox();
            this.mtxtCijena = new System.Windows.Forms.MaskedTextBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxProizvod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 71);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv :";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(333, 131);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(105, 34);
            this.btnDodajProizvod.TabIndex = 1;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(12, 18);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(37, 13);
            this.lblVrsta.TabIndex = 2;
            this.lblVrsta.Text = "Vrsta :";
            // 
            // lblSifraProizvoda
            // 
            this.lblSifraProizvoda.AutoSize = true;
            this.lblSifraProizvoda.Location = new System.Drawing.Point(12, 45);
            this.lblSifraProizvoda.Name = "lblSifraProizvoda";
            this.lblSifraProizvoda.Size = new System.Drawing.Size(83, 13);
            this.lblSifraProizvoda.TabIndex = 3;
            this.lblSifraProizvoda.Text = "Šifra proizvoda :";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(12, 98);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(42, 13);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena :";
            // 
            // lblJedinicaMjere
            // 
            this.lblJedinicaMjere.AutoSize = true;
            this.lblJedinicaMjere.Location = new System.Drawing.Point(172, 98);
            this.lblJedinicaMjere.Name = "lblJedinicaMjere";
            this.lblJedinicaMjere.Size = new System.Drawing.Size(61, 13);
            this.lblJedinicaMjere.TabIndex = 5;
            this.lblJedinicaMjere.Text = "Jed. mjere :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Slika :";
            // 
            // btnDodajS
            // 
            this.btnDodajS.Location = new System.Drawing.Point(260, 137);
            this.btnDodajS.Name = "btnDodajS";
            this.btnDodajS.Size = new System.Drawing.Size(55, 23);
            this.btnDodajS.TabIndex = 7;
            this.btnDodajS.Text = "Dodaj";
            this.btnDodajS.UseVisualStyleBackColor = true;
            this.btnDodajS.Click += new System.EventHandler(this.btnDodajS_Click);
            // 
            // cmbVrste
            // 
            this.cmbVrste.FormattingEnabled = true;
            this.cmbVrste.Location = new System.Drawing.Point(101, 15);
            this.cmbVrste.Name = "cmbVrste";
            this.cmbVrste.Size = new System.Drawing.Size(206, 21);
            this.cmbVrste.TabIndex = 8;
            this.cmbVrste.SelectedIndexChanged += new System.EventHandler(this.cmbVrste_SelectedIndexChanged);
            // 
            // txtbSifraProizvoda
            // 
            this.txtbSifraProizvoda.Location = new System.Drawing.Point(101, 42);
            this.txtbSifraProizvoda.Name = "txtbSifraProizvoda";
            this.txtbSifraProizvoda.Size = new System.Drawing.Size(206, 20);
            this.txtbSifraProizvoda.TabIndex = 9;
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Location = new System.Drawing.Point(101, 68);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(206, 20);
            this.txtbNaziv.TabIndex = 10;
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(239, 95);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(68, 21);
            this.cmbJedinicaMjere.TabIndex = 12;
            // 
            // txtbSlika
            // 
            this.txtbSlika.Location = new System.Drawing.Point(101, 139);
            this.txtbSlika.Name = "txtbSlika";
            this.txtbSlika.Size = new System.Drawing.Size(153, 20);
            this.txtbSlika.TabIndex = 13;
            // 
            // mtxtCijena
            // 
            this.mtxtCijena.Location = new System.Drawing.Point(101, 98);
            this.mtxtCijena.Mask = "0000.00";
            this.mtxtCijena.Name = "mtxtCijena";
            this.mtxtCijena.Size = new System.Drawing.Size(65, 20);
            this.mtxtCijena.TabIndex = 15;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AllowUserToOrderColumns = true;
            this.dgvProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(15, 176);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 55;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(422, 106);
            this.dgvProizvodi.TabIndex = 16;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBoxProizvod
            // 
            this.pictureBoxProizvod.Location = new System.Drawing.Point(313, 15);
            this.pictureBoxProizvod.Name = "pictureBoxProizvod";
            this.pictureBoxProizvod.Size = new System.Drawing.Size(124, 96);
            this.pictureBoxProizvod.TabIndex = 17;
            this.pictureBoxProizvod.TabStop = false;
            // 
            // frmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 294);
            this.Controls.Add(this.pictureBoxProizvod);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.mtxtCijena);
            this.Controls.Add(this.txtbSlika);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.txtbSifraProizvoda);
            this.Controls.Add(this.cmbVrste);
            this.Controls.Add(this.btnDodajS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJedinicaMjere);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblSifraProizvoda);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmDodajProizvod";
            this.Text = "Dodaj proizvod";
            this.Load += new System.EventHandler(this.frmDodajProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblSifraProizvoda;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblJedinicaMjere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajS;
        private System.Windows.Forms.ComboBox cmbVrste;
        private System.Windows.Forms.TextBox txtbSifraProizvoda;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;
        private System.Windows.Forms.TextBox txtbSlika;
        private System.Windows.Forms.MaskedTextBox mtxtCijena;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.PictureBox pictureBoxProizvod;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}