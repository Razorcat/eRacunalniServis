namespace eRacunalniServis.Forms.Prodaja
{
    partial class frmNovaProdaja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaProdaja));
            this.grpbKupac = new System.Windows.Forms.GroupBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnOdaberiKupca = new System.Windows.Forms.Button();
            this.grbProizvodi = new System.Windows.Forms.GroupBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPopust = new System.Windows.Forms.Label();
            this.ntxtbPopust = new System.Windows.Forms.NumericUpDown();
            this.ntxtbKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnDodajP = new System.Windows.Forms.Button();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtbSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.grbProdaja = new System.Windows.Forms.GroupBox();
            this.txtbIznos = new System.Windows.Forms.TextBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.dgvProdaja = new System.Windows.Forms.DataGridView();
            this.btnBrisiStavku = new System.Windows.Forms.Button();
            this.btnZakljuciProdaju = new System.Windows.Forms.Button();
            this.espProizvodiSelectBySifraNazivResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbKupac.SuspendLayout();
            this.grbProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.grbProdaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espProizvodiSelectBySifraNazivResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbKupac
            // 
            this.grpbKupac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbKupac.Controls.Add(this.txtbPrezime);
            this.grpbKupac.Controls.Add(this.txtbIme);
            this.grpbKupac.Controls.Add(this.lblPrezime);
            this.grpbKupac.Controls.Add(this.btnNoviKupac);
            this.grpbKupac.Controls.Add(this.lblIme);
            this.grpbKupac.Controls.Add(this.btnOdaberiKupca);
            this.grpbKupac.Location = new System.Drawing.Point(13, 13);
            this.grpbKupac.Name = "grpbKupac";
            this.grpbKupac.Size = new System.Drawing.Size(500, 68);
            this.grpbKupac.TabIndex = 0;
            this.grpbKupac.TabStop = false;
            this.grpbKupac.Text = "Kupac";
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPrezime.Location = new System.Drawing.Point(60, 39);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.ReadOnly = true;
            this.txtbPrezime.Size = new System.Drawing.Size(272, 20);
            this.txtbPrezime.TabIndex = 5;
            // 
            // txtbIme
            // 
            this.txtbIme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIme.Location = new System.Drawing.Point(60, 13);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.ReadOnly = true;
            this.txtbIme.Size = new System.Drawing.Size(272, 20);
            this.txtbIme.TabIndex = 4;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(7, 42);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNoviKupac.Location = new System.Drawing.Point(419, 13);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(75, 46);
            this.btnNoviKupac.TabIndex = 2;
            this.btnNoviKupac.Text = "Novi kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            this.btnNoviKupac.Click += new System.EventHandler(this.btnNoviKupac_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(7, 16);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // btnOdaberiKupca
            // 
            this.btnOdaberiKupca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdaberiKupca.Location = new System.Drawing.Point(338, 13);
            this.btnOdaberiKupca.Name = "btnOdaberiKupca";
            this.btnOdaberiKupca.Size = new System.Drawing.Size(75, 46);
            this.btnOdaberiKupca.TabIndex = 0;
            this.btnOdaberiKupca.Text = "Odaberi kupca";
            this.btnOdaberiKupca.UseVisualStyleBackColor = true;
            this.btnOdaberiKupca.Click += new System.EventHandler(this.btnOdaberiKupca_Click);
            // 
            // grbProizvodi
            // 
            this.grbProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProizvodi.Controls.Add(this.lblP);
            this.grbProizvodi.Controls.Add(this.lblPopust);
            this.grbProizvodi.Controls.Add(this.ntxtbPopust);
            this.grbProizvodi.Controls.Add(this.ntxtbKolicina);
            this.grbProizvodi.Controls.Add(this.lblKolicina);
            this.grbProizvodi.Controls.Add(this.btnDodajP);
            this.grbProizvodi.Controls.Add(this.txtbNaziv);
            this.grbProizvodi.Controls.Add(this.lblNaziv);
            this.grbProizvodi.Controls.Add(this.txtbSifra);
            this.grbProizvodi.Controls.Add(this.lblSifra);
            this.grbProizvodi.Controls.Add(this.dgvProizvodi);
            this.grbProizvodi.Location = new System.Drawing.Point(13, 88);
            this.grbProizvodi.Name = "grbProizvodi";
            this.grbProizvodi.Size = new System.Drawing.Size(500, 146);
            this.grbProizvodi.TabIndex = 1;
            this.grbProizvodi.TabStop = false;
            this.grbProizvodi.Text = "Proizvodi";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(473, 23);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(15, 13);
            this.lblP.TabIndex = 11;
            this.lblP.Text = "%";
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(369, 23);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(43, 13);
            this.lblPopust.TabIndex = 10;
            this.lblPopust.Text = "Popust:";
            // 
            // ntxtbPopust
            // 
            this.ntxtbPopust.Location = new System.Drawing.Point(418, 20);
            this.ntxtbPopust.Name = "ntxtbPopust";
            this.ntxtbPopust.Size = new System.Drawing.Size(49, 20);
            this.ntxtbPopust.TabIndex = 9;
            // 
            // ntxtbKolicina
            // 
            this.ntxtbKolicina.Location = new System.Drawing.Point(316, 19);
            this.ntxtbKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ntxtbKolicina.Name = "ntxtbKolicina";
            this.ntxtbKolicina.Size = new System.Drawing.Size(47, 20);
            this.ntxtbKolicina.TabIndex = 8;
            this.ntxtbKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(263, 21);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodajP
            // 
            this.btnDodajP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDodajP.Location = new System.Drawing.Point(419, 94);
            this.btnDodajP.Name = "btnDodajP";
            this.btnDodajP.Size = new System.Drawing.Size(75, 46);
            this.btnDodajP.TabIndex = 5;
            this.btnDodajP.Text = "Dodaj proizvod";
            this.btnDodajP.UseVisualStyleBackColor = true;
            this.btnDodajP.Click += new System.EventHandler(this.btnDodajP_Click);
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Location = new System.Drawing.Point(198, 19);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(59, 20);
            this.txtbNaziv.TabIndex = 4;
            this.txtbNaziv.TextChanged += new System.EventHandler(this.txtbNaziv_TextChanged);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(155, 22);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtbSifra
            // 
            this.txtbSifra.Location = new System.Drawing.Point(96, 19);
            this.txtbSifra.MaxLength = 55;
            this.txtbSifra.Name = "txtbSifra";
            this.txtbSifra.Size = new System.Drawing.Size(52, 20);
            this.txtbSifra.TabIndex = 2;
            this.txtbSifra.TextChanged += new System.EventHandler(this.txtbSifra_TextChanged);
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(10, 22);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(80, 13);
            this.lblSifra.TabIndex = 1;
            this.lblSifra.Text = "Šifra proizvoda:";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AllowUserToOrderColumns = true;
            this.dgvProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(7, 46);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(406, 94);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellClick);
            // 
            // grbProdaja
            // 
            this.grbProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProdaja.Controls.Add(this.txtbIznos);
            this.grbProdaja.Controls.Add(this.lblIznos);
            this.grbProdaja.Controls.Add(this.dgvProdaja);
            this.grbProdaja.Controls.Add(this.btnBrisiStavku);
            this.grbProdaja.Controls.Add(this.btnZakljuciProdaju);
            this.grbProdaja.Location = new System.Drawing.Point(13, 241);
            this.grbProdaja.Name = "grbProdaja";
            this.grbProdaja.Size = new System.Drawing.Size(500, 158);
            this.grbProdaja.TabIndex = 2;
            this.grbProdaja.TabStop = false;
            this.grbProdaja.Text = "Prodaja";
            // 
            // txtbIznos
            // 
            this.txtbIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIznos.Location = new System.Drawing.Point(49, 130);
            this.txtbIznos.Name = "txtbIznos";
            this.txtbIznos.ReadOnly = true;
            this.txtbIznos.Size = new System.Drawing.Size(100, 20);
            this.txtbIznos.TabIndex = 10;
            // 
            // lblIznos
            // 
            this.lblIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(7, 133);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(35, 13);
            this.lblIznos.TabIndex = 9;
            this.lblIznos.Text = "Iznos:";
            // 
            // dgvProdaja
            // 
            this.dgvProdaja.AllowUserToAddRows = false;
            this.dgvProdaja.AllowUserToDeleteRows = false;
            this.dgvProdaja.AllowUserToOrderColumns = true;
            this.dgvProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdaja.Location = new System.Drawing.Point(7, 20);
            this.dgvProdaja.Name = "dgvProdaja";
            this.dgvProdaja.ReadOnly = true;
            this.dgvProdaja.Size = new System.Drawing.Size(406, 99);
            this.dgvProdaja.TabIndex = 8;
            // 
            // btnBrisiStavku
            // 
            this.btnBrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrisiStavku.Location = new System.Drawing.Point(419, 19);
            this.btnBrisiStavku.Name = "btnBrisiStavku";
            this.btnBrisiStavku.Size = new System.Drawing.Size(75, 46);
            this.btnBrisiStavku.TabIndex = 7;
            this.btnBrisiStavku.Text = "Briši stavku";
            this.btnBrisiStavku.UseVisualStyleBackColor = true;
            this.btnBrisiStavku.Click += new System.EventHandler(this.btnBrisiStavku_Click);
            // 
            // btnZakljuciProdaju
            // 
            this.btnZakljuciProdaju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZakljuciProdaju.Location = new System.Drawing.Point(419, 106);
            this.btnZakljuciProdaju.Name = "btnZakljuciProdaju";
            this.btnZakljuciProdaju.Size = new System.Drawing.Size(75, 46);
            this.btnZakljuciProdaju.TabIndex = 6;
            this.btnZakljuciProdaju.Text = "Zaključi prodaju";
            this.btnZakljuciProdaju.UseVisualStyleBackColor = true;
            this.btnZakljuciProdaju.Click += new System.EventHandler(this.btnZakljuciProdaju_Click);
            // 
            // espProizvodiSelectBySifraNazivResultBindingSource
            // 
            this.espProizvodiSelectBySifraNazivResultBindingSource.DataSource = typeof(eRacunalniServis_Servis.Data.esp_Proizvodi_SelectBySifraNaziv_Result);
            // 
            // frmNovaProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 411);
            this.Controls.Add(this.grbProdaja);
            this.Controls.Add(this.grbProizvodi);
            this.Controls.Add(this.grpbKupac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovaProdaja";
            this.Text = "Prodaja";
            this.grpbKupac.ResumeLayout(false);
            this.grpbKupac.PerformLayout();
            this.grbProizvodi.ResumeLayout(false);
            this.grbProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.grbProdaja.ResumeLayout(false);
            this.grbProdaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espProizvodiSelectBySifraNazivResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbKupac;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnOdaberiKupca;
        private System.Windows.Forms.GroupBox grbProizvodi;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.BindingSource espProizvodiSelectBySifraNazivResultBindingSource;
        private System.Windows.Forms.TextBox txtbSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnDodajP;
        private System.Windows.Forms.GroupBox grbProdaja;
        private System.Windows.Forms.NumericUpDown ntxtbKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtbIznos;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.DataGridView dgvProdaja;
        private System.Windows.Forms.Button btnBrisiStavku;
        private System.Windows.Forms.Button btnZakljuciProdaju;
        private System.Windows.Forms.NumericUpDown ntxtbPopust;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label lblP;

    }
}