namespace eRacunalniServis.Forms.Proizvodi
{
    partial class frmNabavaProizvoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaProizvoda));
            this.gbDobavljac = new System.Windows.Forms.GroupBox();
            this.btnOdaberiDobavljaca = new System.Windows.Forms.Button();
            this.txtbTelefon = new System.Windows.Forms.TextBox();
            this.txtbKontaktOsoba = new System.Windows.Forms.TextBox();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblKontaktOsoba = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.gbUlaznaFaktura = new System.Windows.Forms.GroupBox();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.lblBrojFakture = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznosR = new System.Windows.Forms.Label();
            this.lblPDV = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.cmbSkladista = new System.Windows.Forms.ComboBox();
            this.txtbBrojFakture = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtbIznosRacuna = new System.Windows.Forms.TextBox();
            this.txtbPDV = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbStavke = new System.Windows.Forms.GroupBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtbSifraProizvoda = new System.Windows.Forms.TextBox();
            this.mtxtbKolicina = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbCijena = new System.Windows.Forms.MaskedTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.stavkeGrid = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDobavljac.SuspendLayout();
            this.gbUlaznaFaktura.SuspendLayout();
            this.gbStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDobavljac
            // 
            this.gbDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDobavljac.Controls.Add(this.btnOdaberiDobavljaca);
            this.gbDobavljac.Controls.Add(this.txtbTelefon);
            this.gbDobavljac.Controls.Add(this.txtbKontaktOsoba);
            this.gbDobavljac.Controls.Add(this.txtbNaziv);
            this.gbDobavljac.Controls.Add(this.lblTelefon);
            this.gbDobavljac.Controls.Add(this.lblKontaktOsoba);
            this.gbDobavljac.Controls.Add(this.lblNaziv);
            this.gbDobavljac.Location = new System.Drawing.Point(13, 13);
            this.gbDobavljac.Name = "gbDobavljac";
            this.gbDobavljac.Size = new System.Drawing.Size(451, 99);
            this.gbDobavljac.TabIndex = 0;
            this.gbDobavljac.TabStop = false;
            this.gbDobavljac.Text = "Dobavljač";
            // 
            // btnOdaberiDobavljaca
            // 
            this.btnOdaberiDobavljaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdaberiDobavljaca.Location = new System.Drawing.Point(334, 13);
            this.btnOdaberiDobavljaca.Name = "btnOdaberiDobavljaca";
            this.btnOdaberiDobavljaca.Size = new System.Drawing.Size(111, 75);
            this.btnOdaberiDobavljaca.TabIndex = 6;
            this.btnOdaberiDobavljaca.Text = "Odaberi dobavljača";
            this.btnOdaberiDobavljaca.UseVisualStyleBackColor = true;
            this.btnOdaberiDobavljaca.Click += new System.EventHandler(this.btnOdaberiDobavljaca_Click);
            // 
            // txtbTelefon
            // 
            this.txtbTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTelefon.Location = new System.Drawing.Point(94, 68);
            this.txtbTelefon.Name = "txtbTelefon";
            this.txtbTelefon.ReadOnly = true;
            this.txtbTelefon.Size = new System.Drawing.Size(234, 20);
            this.txtbTelefon.TabIndex = 5;
            // 
            // txtbKontaktOsoba
            // 
            this.txtbKontaktOsoba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbKontaktOsoba.Location = new System.Drawing.Point(94, 42);
            this.txtbKontaktOsoba.Name = "txtbKontaktOsoba";
            this.txtbKontaktOsoba.ReadOnly = true;
            this.txtbKontaktOsoba.Size = new System.Drawing.Size(234, 20);
            this.txtbKontaktOsoba.TabIndex = 4;
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNaziv.Location = new System.Drawing.Point(94, 13);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.ReadOnly = true;
            this.txtbNaziv.Size = new System.Drawing.Size(234, 20);
            this.txtbNaziv.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 71);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblKontaktOsoba
            // 
            this.lblKontaktOsoba.AutoSize = true;
            this.lblKontaktOsoba.Location = new System.Drawing.Point(6, 45);
            this.lblKontaktOsoba.Name = "lblKontaktOsoba";
            this.lblKontaktOsoba.Size = new System.Drawing.Size(82, 13);
            this.lblKontaktOsoba.TabIndex = 1;
            this.lblKontaktOsoba.Text = "Kontakt osoba :";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(6, 16);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv :";
            // 
            // gbUlaznaFaktura
            // 
            this.gbUlaznaFaktura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUlaznaFaktura.Controls.Add(this.richTextBox1);
            this.gbUlaznaFaktura.Controls.Add(this.txtbPDV);
            this.gbUlaznaFaktura.Controls.Add(this.txtbIznosRacuna);
            this.gbUlaznaFaktura.Controls.Add(this.dtpDatum);
            this.gbUlaznaFaktura.Controls.Add(this.txtbBrojFakture);
            this.gbUlaznaFaktura.Controls.Add(this.cmbSkladista);
            this.gbUlaznaFaktura.Controls.Add(this.lblNapomena);
            this.gbUlaznaFaktura.Controls.Add(this.lblPDV);
            this.gbUlaznaFaktura.Controls.Add(this.lblIznosR);
            this.gbUlaznaFaktura.Controls.Add(this.lblDatum);
            this.gbUlaznaFaktura.Controls.Add(this.lblBrojFakture);
            this.gbUlaznaFaktura.Controls.Add(this.lblSkladiste);
            this.gbUlaznaFaktura.Location = new System.Drawing.Point(13, 119);
            this.gbUlaznaFaktura.Name = "gbUlaznaFaktura";
            this.gbUlaznaFaktura.Size = new System.Drawing.Size(451, 127);
            this.gbUlaznaFaktura.TabIndex = 1;
            this.gbUlaznaFaktura.TabStop = false;
            this.gbUlaznaFaktura.Text = "Ulazna faktura";
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(6, 22);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(56, 13);
            this.lblSkladiste.TabIndex = 0;
            this.lblSkladiste.Text = "Skladište :";
            // 
            // lblBrojFakture
            // 
            this.lblBrojFakture.AutoSize = true;
            this.lblBrojFakture.Location = new System.Drawing.Point(6, 47);
            this.lblBrojFakture.Name = "lblBrojFakture";
            this.lblBrojFakture.Size = new System.Drawing.Size(67, 13);
            this.lblBrojFakture.TabIndex = 1;
            this.lblBrojFakture.Text = "Broj fakture :";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(6, 76);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(44, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum :";
            // 
            // lblIznosR
            // 
            this.lblIznosR.AutoSize = true;
            this.lblIznosR.Location = new System.Drawing.Point(6, 99);
            this.lblIznosR.Name = "lblIznosR";
            this.lblIznosR.Size = new System.Drawing.Size(74, 13);
            this.lblIznosR.TabIndex = 3;
            this.lblIznosR.Text = "Iznos računa :";
            // 
            // lblPDV
            // 
            this.lblPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPDV.AutoSize = true;
            this.lblPDV.Location = new System.Drawing.Point(162, 99);
            this.lblPDV.Name = "lblPDV";
            this.lblPDV.Size = new System.Drawing.Size(35, 13);
            this.lblPDV.TabIndex = 4;
            this.lblPDV.Text = "PDV :";
            // 
            // lblNapomena
            // 
            this.lblNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(331, 16);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(65, 13);
            this.lblNapomena.TabIndex = 5;
            this.lblNapomena.Text = "Napomena :";
            // 
            // cmbSkladista
            // 
            this.cmbSkladista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSkladista.FormattingEnabled = true;
            this.cmbSkladista.Location = new System.Drawing.Point(86, 19);
            this.cmbSkladista.Name = "cmbSkladista";
            this.cmbSkladista.Size = new System.Drawing.Size(172, 21);
            this.cmbSkladista.TabIndex = 6;
            // 
            // txtbBrojFakture
            // 
            this.txtbBrojFakture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbBrojFakture.Location = new System.Drawing.Point(86, 44);
            this.txtbBrojFakture.MaxLength = 20;
            this.txtbBrojFakture.Name = "txtbBrojFakture";
            this.txtbBrojFakture.Size = new System.Drawing.Size(172, 20);
            this.txtbBrojFakture.TabIndex = 7;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.Location = new System.Drawing.Point(86, 70);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(172, 20);
            this.dtpDatum.TabIndex = 8;
            // 
            // txtbIznosRacuna
            // 
            this.txtbIznosRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIznosRacuna.Location = new System.Drawing.Point(86, 96);
            this.txtbIznosRacuna.Name = "txtbIznosRacuna";
            this.txtbIznosRacuna.ReadOnly = true;
            this.txtbIznosRacuna.Size = new System.Drawing.Size(70, 20);
            this.txtbIznosRacuna.TabIndex = 9;
            // 
            // txtbPDV
            // 
            this.txtbPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPDV.Location = new System.Drawing.Point(203, 96);
            this.txtbPDV.Name = "txtbPDV";
            this.txtbPDV.ReadOnly = true;
            this.txtbPDV.Size = new System.Drawing.Size(55, 20);
            this.txtbPDV.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(264, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 84);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // gbStavke
            // 
            this.gbStavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStavke.Controls.Add(this.stavkeGrid);
            this.gbStavke.Controls.Add(this.btnZakljuci);
            this.gbStavke.Controls.Add(this.btnDodaj);
            this.gbStavke.Controls.Add(this.mtxtbCijena);
            this.gbStavke.Controls.Add(this.mtxtbKolicina);
            this.gbStavke.Controls.Add(this.txtbSifraProizvoda);
            this.gbStavke.Controls.Add(this.lblCijena);
            this.gbStavke.Controls.Add(this.lblKolicina);
            this.gbStavke.Controls.Add(this.lblSifra);
            this.gbStavke.Location = new System.Drawing.Point(13, 253);
            this.gbStavke.Name = "gbStavke";
            this.gbStavke.Size = new System.Drawing.Size(445, 147);
            this.gbStavke.TabIndex = 2;
            this.gbStavke.TabStop = false;
            this.gbStavke.Text = "Stavke";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(6, 16);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(83, 13);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Šifra proizvoda :";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(6, 42);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(50, 13);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Količina :";
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(200, 42);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(42, 13);
            this.lblCijena.TabIndex = 2;
            this.lblCijena.Text = "Cijena :";
            // 
            // txtbSifraProizvoda
            // 
            this.txtbSifraProizvoda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbSifraProizvoda.Location = new System.Drawing.Point(95, 13);
            this.txtbSifraProizvoda.Name = "txtbSifraProizvoda";
            this.txtbSifraProizvoda.Size = new System.Drawing.Size(100, 20);
            this.txtbSifraProizvoda.TabIndex = 3;
            // 
            // mtxtbKolicina
            // 
            this.mtxtbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtbKolicina.Location = new System.Drawing.Point(94, 39);
            this.mtxtbKolicina.Mask = "000";
            this.mtxtbKolicina.Name = "mtxtbKolicina";
            this.mtxtbKolicina.Size = new System.Drawing.Size(100, 20);
            this.mtxtbKolicina.TabIndex = 4;
            // 
            // mtxtbCijena
            // 
            this.mtxtbCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtbCijena.Location = new System.Drawing.Point(248, 39);
            this.mtxtbCijena.Mask = "0000.00";
            this.mtxtbCijena.Name = "mtxtbCijena";
            this.mtxtbCijena.Size = new System.Drawing.Size(100, 20);
            this.mtxtbCijena.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(364, 36);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZakljuci.Location = new System.Drawing.Point(364, 95);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(75, 46);
            this.btnZakljuci.TabIndex = 7;
            this.btnZakljuci.Text = "Zaključi";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            // 
            // stavkeGrid
            // 
            this.stavkeGrid.AllowUserToAddRows = false;
            this.stavkeGrid.AllowUserToDeleteRows = false;
            this.stavkeGrid.AllowUserToOrderColumns = true;
            this.stavkeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stavkeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stavkeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stavkeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Proizvodi,
            this.Kolicina,
            this.Cijena});
            this.stavkeGrid.GridColor = System.Drawing.SystemColors.Control;
            this.stavkeGrid.Location = new System.Drawing.Point(6, 65);
            this.stavkeGrid.Name = "stavkeGrid";
            this.stavkeGrid.ReadOnly = true;
            this.stavkeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeGrid.Size = new System.Drawing.Size(342, 75);
            this.stavkeGrid.TabIndex = 8;
            this.stavkeGrid.TabStop = false;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            // 
            // Proizvodi
            // 
            this.Proizvodi.DataPropertyName = "Proizvodi";
            this.Proizvodi.HeaderText = "Proizvod";
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // frmNabavaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 412);
            this.Controls.Add(this.gbStavke);
            this.Controls.Add(this.gbUlaznaFaktura);
            this.Controls.Add(this.gbDobavljac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "frmNabavaProizvoda";
            this.Text = "Nabava proizvoda";
            this.Load += new System.EventHandler(this.frmNabavaProizvoda_Load);
            this.gbDobavljac.ResumeLayout(false);
            this.gbDobavljac.PerformLayout();
            this.gbUlaznaFaktura.ResumeLayout(false);
            this.gbUlaznaFaktura.PerformLayout();
            this.gbStavke.ResumeLayout(false);
            this.gbStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDobavljac;
        private System.Windows.Forms.Button btnOdaberiDobavljaca;
        private System.Windows.Forms.TextBox txtbTelefon;
        private System.Windows.Forms.TextBox txtbKontaktOsoba;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblKontaktOsoba;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.GroupBox gbUlaznaFaktura;
        private System.Windows.Forms.Label lblIznosR;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblBrojFakture;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblPDV;
        private System.Windows.Forms.TextBox txtbBrojFakture;
        private System.Windows.Forms.ComboBox cmbSkladista;
        private System.Windows.Forms.TextBox txtbIznosRacuna;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtbPDV;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox gbStavke;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.MaskedTextBox mtxtbCijena;
        private System.Windows.Forms.MaskedTextBox mtxtbKolicina;
        private System.Windows.Forms.TextBox txtbSifraProizvoda;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.DataGridView stavkeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}