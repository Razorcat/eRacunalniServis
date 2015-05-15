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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaProdaja));
            this.grbProizvodi = new System.Windows.Forms.GroupBox();
            this.lblDostupno = new System.Windows.Forms.Label();
            this.txtStanjeNaSkladistu = new System.Windows.Forms.TextBox();
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
            this.cmbSkladisteList = new System.Windows.Forms.ComboBox();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.txtbBrRacuna = new System.Windows.Forms.TextBox();
            this.txtbIznosSaPDV = new System.Windows.Forms.TextBox();
            this.lblIznosSaPDV = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.txtbIznosBezPDV = new System.Windows.Forms.TextBox();
            this.lblIznosbezPDV = new System.Windows.Forms.Label();
            this.dgvProdaja = new System.Windows.Forms.DataGridView();
            this.btnBrisiStavku = new System.Windows.Forms.Button();
            this.btnZakljuciProdaju = new System.Windows.Forms.Button();
            this.lblCijena = new System.Windows.Forms.Label();
            this.mtxtbCijena = new System.Windows.Forms.MaskedTextBox();
            this.grbProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.grbProdaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProizvodi
            // 
            this.grbProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProizvodi.Controls.Add(this.mtxtbCijena);
            this.grbProizvodi.Controls.Add(this.lblCijena);
            this.grbProizvodi.Controls.Add(this.lblDostupno);
            this.grbProizvodi.Controls.Add(this.txtStanjeNaSkladistu);
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
            this.grbProizvodi.Location = new System.Drawing.Point(13, 12);
            this.grbProizvodi.Name = "grbProizvodi";
            this.grbProizvodi.Size = new System.Drawing.Size(492, 186);
            this.grbProizvodi.TabIndex = 1;
            this.grbProizvodi.TabStop = false;
            this.grbProizvodi.Text = "Proizvodi";
            // 
            // lblDostupno
            // 
            this.lblDostupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDostupno.AutoSize = true;
            this.lblDostupno.Location = new System.Drawing.Point(424, 52);
            this.lblDostupno.Name = "lblDostupno";
            this.lblDostupno.Size = new System.Drawing.Size(56, 13);
            this.lblDostupno.TabIndex = 16;
            this.lblDostupno.Text = "Dostupno:";
            // 
            // txtStanjeNaSkladistu
            // 
            this.txtStanjeNaSkladistu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStanjeNaSkladistu.Location = new System.Drawing.Point(414, 68);
            this.txtStanjeNaSkladistu.MaxLength = 55;
            this.txtStanjeNaSkladistu.Name = "txtStanjeNaSkladistu";
            this.txtStanjeNaSkladistu.ReadOnly = true;
            this.txtStanjeNaSkladistu.Size = new System.Drawing.Size(72, 20);
            this.txtStanjeNaSkladistu.TabIndex = 15;
            // 
            // lblP
            // 
            this.lblP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(389, 162);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(15, 13);
            this.lblP.TabIndex = 11;
            this.lblP.Text = "%";
            // 
            // lblPopust
            // 
            this.lblPopust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(285, 162);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(43, 13);
            this.lblPopust.TabIndex = 10;
            this.lblPopust.Text = "Popust:";
            // 
            // ntxtbPopust
            // 
            this.ntxtbPopust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ntxtbPopust.Location = new System.Drawing.Point(334, 160);
            this.ntxtbPopust.Name = "ntxtbPopust";
            this.ntxtbPopust.Size = new System.Drawing.Size(49, 20);
            this.ntxtbPopust.TabIndex = 9;
            // 
            // ntxtbKolicina
            // 
            this.ntxtbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ntxtbKolicina.Location = new System.Drawing.Point(232, 160);
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
            this.lblKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(179, 162);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodajP
            // 
            this.btnDodajP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDodajP.Location = new System.Drawing.Point(411, 131);
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
            this.txtbSifra.Location = new System.Drawing.Point(93, 20);
            this.txtbSifra.MaxLength = 55;
            this.txtbSifra.Name = "txtbSifra";
            this.txtbSifra.Size = new System.Drawing.Size(52, 20);
            this.txtbSifra.TabIndex = 2;
            this.txtbSifra.TextChanged += new System.EventHandler(this.txtbSifra_TextChanged);
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(7, 22);
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
            this.dgvProizvodi.Location = new System.Drawing.Point(7, 45);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(398, 103);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellClick);
            // 
            // grbProdaja
            // 
            this.grbProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProdaja.Controls.Add(this.cmbSkladisteList);
            this.grbProdaja.Controls.Add(this.lblSkladiste);
            this.grbProdaja.Controls.Add(this.txtbBrRacuna);
            this.grbProdaja.Controls.Add(this.txtbIznosSaPDV);
            this.grbProdaja.Controls.Add(this.lblIznosSaPDV);
            this.grbProdaja.Controls.Add(this.lblBrojRacuna);
            this.grbProdaja.Controls.Add(this.txtbIznosBezPDV);
            this.grbProdaja.Controls.Add(this.lblIznosbezPDV);
            this.grbProdaja.Controls.Add(this.dgvProdaja);
            this.grbProdaja.Controls.Add(this.btnBrisiStavku);
            this.grbProdaja.Controls.Add(this.btnZakljuciProdaju);
            this.grbProdaja.Location = new System.Drawing.Point(13, 204);
            this.grbProdaja.Name = "grbProdaja";
            this.grbProdaja.Size = new System.Drawing.Size(492, 214);
            this.grbProdaja.TabIndex = 2;
            this.grbProdaja.TabStop = false;
            this.grbProdaja.Text = "Prodaja";
            // 
            // cmbSkladisteList
            // 
            this.cmbSkladisteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSkladisteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkladisteList.FormattingEnabled = true;
            this.cmbSkladisteList.Location = new System.Drawing.Point(264, 18);
            this.cmbSkladisteList.Name = "cmbSkladisteList";
            this.cmbSkladisteList.Size = new System.Drawing.Size(140, 21);
            this.cmbSkladisteList.TabIndex = 24;
            this.cmbSkladisteList.SelectedIndexChanged += new System.EventHandler(this.cmbSkladisteList_SelectedIndexChanged);
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(205, 21);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(53, 13);
            this.lblSkladiste.TabIndex = 25;
            this.lblSkladiste.Text = "Skladište:";
            // 
            // txtbBrRacuna
            // 
            this.txtbBrRacuna.Location = new System.Drawing.Point(76, 19);
            this.txtbBrRacuna.MaxLength = 55;
            this.txtbBrRacuna.Name = "txtbBrRacuna";
            this.txtbBrRacuna.Size = new System.Drawing.Size(72, 20);
            this.txtbBrRacuna.TabIndex = 14;
            // 
            // txtbIznosSaPDV
            // 
            this.txtbIznosSaPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIznosSaPDV.Location = new System.Drawing.Point(305, 186);
            this.txtbIznosSaPDV.Name = "txtbIznosSaPDV";
            this.txtbIznosSaPDV.ReadOnly = true;
            this.txtbIznosSaPDV.Size = new System.Drawing.Size(100, 20);
            this.txtbIznosSaPDV.TabIndex = 13;
            // 
            // lblIznosSaPDV
            // 
            this.lblIznosSaPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIznosSaPDV.AutoSize = true;
            this.lblIznosSaPDV.Location = new System.Drawing.Point(208, 189);
            this.lblIznosSaPDV.Name = "lblIznosSaPDV";
            this.lblIznosSaPDV.Size = new System.Drawing.Size(91, 13);
            this.lblIznosSaPDV.TabIndex = 12;
            this.lblIznosSaPDV.Text = "Iznos sa PDV-om:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(6, 22);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(64, 13);
            this.lblBrojRacuna.TabIndex = 11;
            this.lblBrojRacuna.Text = "Broj računa:";
            // 
            // txtbIznosBezPDV
            // 
            this.txtbIznosBezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIznosBezPDV.Location = new System.Drawing.Point(102, 186);
            this.txtbIznosBezPDV.Name = "txtbIznosBezPDV";
            this.txtbIznosBezPDV.ReadOnly = true;
            this.txtbIznosBezPDV.Size = new System.Drawing.Size(100, 20);
            this.txtbIznosBezPDV.TabIndex = 10;
            // 
            // lblIznosbezPDV
            // 
            this.lblIznosbezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIznosbezPDV.AutoSize = true;
            this.lblIznosbezPDV.Location = new System.Drawing.Point(7, 189);
            this.lblIznosbezPDV.Name = "lblIznosbezPDV";
            this.lblIznosbezPDV.Size = new System.Drawing.Size(89, 13);
            this.lblIznosbezPDV.TabIndex = 9;
            this.lblIznosbezPDV.Text = "Iznos bez PDV-a:";
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
            this.dgvProdaja.Location = new System.Drawing.Point(7, 45);
            this.dgvProdaja.Name = "dgvProdaja";
            this.dgvProdaja.ReadOnly = true;
            this.dgvProdaja.Size = new System.Drawing.Size(398, 130);
            this.dgvProdaja.TabIndex = 8;
            this.dgvProdaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdaja_CellClick);
            // 
            // btnBrisiStavku
            // 
            this.btnBrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrisiStavku.Location = new System.Drawing.Point(411, 19);
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
            this.btnZakljuciProdaju.Location = new System.Drawing.Point(411, 162);
            this.btnZakljuciProdaju.Name = "btnZakljuciProdaju";
            this.btnZakljuciProdaju.Size = new System.Drawing.Size(75, 46);
            this.btnZakljuciProdaju.TabIndex = 6;
            this.btnZakljuciProdaju.Text = "Zaključi prodaju";
            this.btnZakljuciProdaju.UseVisualStyleBackColor = true;
            this.btnZakljuciProdaju.Click += new System.EventHandler(this.btnZakljuciProdaju_Click);
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(7, 162);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 17;
            this.lblCijena.Text = "Cijena:";
            // 
            // mtxtbCijena
            // 
            this.mtxtbCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtbCijena.Location = new System.Drawing.Point(52, 160);
            this.mtxtbCijena.Mask = "0000.00";
            this.mtxtbCijena.Name = "mtxtbCijena";
            this.mtxtbCijena.Size = new System.Drawing.Size(110, 20);
            this.mtxtbCijena.TabIndex = 18;
            // 
            // frmNovaProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 430);
            this.Controls.Add(this.grbProdaja);
            this.Controls.Add(this.grbProizvodi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovaProdaja";
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.frmNovaProdaja_Load);
            this.grbProizvodi.ResumeLayout(false);
            this.grbProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.grbProdaja.ResumeLayout(false);
            this.grbProdaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProizvodi;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox txtbSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnDodajP;
        private System.Windows.Forms.GroupBox grbProdaja;
        private System.Windows.Forms.NumericUpDown ntxtbKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtbIznosBezPDV;
        private System.Windows.Forms.Label lblIznosbezPDV;
        private System.Windows.Forms.DataGridView dgvProdaja;
        private System.Windows.Forms.Button btnBrisiStavku;
        private System.Windows.Forms.Button btnZakljuciProdaju;
        private System.Windows.Forms.NumericUpDown ntxtbPopust;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label lblIznosSaPDV;
        private System.Windows.Forms.TextBox txtbIznosSaPDV;
        private System.Windows.Forms.TextBox txtbBrRacuna;
        private System.Windows.Forms.ComboBox cmbSkladisteList;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.TextBox txtStanjeNaSkladistu;
        private System.Windows.Forms.Label lblDostupno;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.MaskedTextBox mtxtbCijena;

    }
}