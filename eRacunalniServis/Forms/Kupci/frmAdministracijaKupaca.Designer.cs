namespace eRacunalniServis.Forms.Kupci
{
    partial class frmAdministracijaKupaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracijaKupaca));
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnPromjeniStatus = new System.Windows.Forms.Button();
            this.btnPromjeniPodatke = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKupci
            // 
            this.dgvKupci.AllowUserToAddRows = false;
            this.dgvKupci.AllowUserToDeleteRows = false;
            this.dgvKupci.AllowUserToOrderColumns = true;
            this.dgvKupci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Location = new System.Drawing.Point(12, 32);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.ReadOnly = true;
            this.dgvKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKupci.Size = new System.Drawing.Size(508, 267);
            this.dgvKupci.TabIndex = 5;
            this.dgvKupci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKupci_CellClick);
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNaziv.Location = new System.Drawing.Point(119, 6);
            this.txtbNaziv.MaxLength = 50;
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(401, 20);
            this.txtbNaziv.TabIndex = 4;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(101, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "Ime/prezime kupca:";
            // 
            // btnPromjeniStatus
            // 
            this.btnPromjeniStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPromjeniStatus.Location = new System.Drawing.Point(12, 319);
            this.btnPromjeniStatus.Name = "btnPromjeniStatus";
            this.btnPromjeniStatus.Size = new System.Drawing.Size(75, 43);
            this.btnPromjeniStatus.TabIndex = 6;
            this.btnPromjeniStatus.Text = "Promjeni status";
            this.btnPromjeniStatus.UseVisualStyleBackColor = true;
            this.btnPromjeniStatus.Click += new System.EventHandler(this.btnPromjeniStatus_Click);
            // 
            // btnPromjeniPodatke
            // 
            this.btnPromjeniPodatke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromjeniPodatke.Location = new System.Drawing.Point(445, 319);
            this.btnPromjeniPodatke.Name = "btnPromjeniPodatke";
            this.btnPromjeniPodatke.Size = new System.Drawing.Size(75, 43);
            this.btnPromjeniPodatke.TabIndex = 7;
            this.btnPromjeniPodatke.Text = "Promjeni podatke";
            this.btnPromjeniPodatke.UseVisualStyleBackColor = true;
            this.btnPromjeniPodatke.Click += new System.EventHandler(this.btnPromjeniPodatke_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIzlaz.Location = new System.Drawing.Point(0, 368);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(532, 23);
            this.btnIzlaz.TabIndex = 8;
            this.btnIzlaz.Text = "Zatvori prozor";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // frmAdministracijaKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 391);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPromjeniPodatke);
            this.Controls.Add(this.btnPromjeniStatus);
            this.Controls.Add(this.dgvKupci);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.lblIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministracijaKupaca";
            this.Text = "Administracija kupaca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKupci;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnPromjeniStatus;
        private System.Windows.Forms.Button btnPromjeniPodatke;
        private System.Windows.Forms.Button btnIzlaz;
    }
}