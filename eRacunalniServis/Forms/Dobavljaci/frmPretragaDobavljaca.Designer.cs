namespace eRacunalniServis.Forms.Dobavljaci
{
    partial class frmPretragaDobavljaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaDobavljaca));
            this.txtbDobavljacNaziv = new System.Windows.Forms.TextBox();
            this.lblNazivD = new System.Windows.Forms.Label();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbDobavljacNaziv
            // 
            this.txtbDobavljacNaziv.Location = new System.Drawing.Point(114, 13);
            this.txtbDobavljacNaziv.MaxLength = 55;
            this.txtbDobavljacNaziv.Name = "txtbDobavljacNaziv";
            this.txtbDobavljacNaziv.Size = new System.Drawing.Size(222, 20);
            this.txtbDobavljacNaziv.TabIndex = 0;
            this.txtbDobavljacNaziv.TextChanged += new System.EventHandler(this.txtbDobavljacNaziv_TextChanged);
            // 
            // lblNazivD
            // 
            this.lblNazivD.AutoSize = true;
            this.lblNazivD.Location = new System.Drawing.Point(13, 16);
            this.lblNazivD.Name = "lblNazivD";
            this.lblNazivD.Size = new System.Drawing.Size(95, 13);
            this.lblNazivD.TabIndex = 2;
            this.lblNazivD.Text = "Naziv dobavljača :";
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.AllowUserToOrderColumns = true;
            this.dgvDobavljaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDobavljaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDobavljaci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.Adresa,
            this.Telefon,
            this.KontaktOsoba,
            this.Email});
            this.dgvDobavljaci.Location = new System.Drawing.Point(12, 39);
            this.dgvDobavljaci.MultiSelect = false;
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(514, 218);
            this.dgvDobavljaci.TabIndex = 1;
            this.dgvDobavljaci.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDobavljaci_CellDoubleClick);
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.ReadOnly = true;
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // frmPretragaDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 269);
            this.Controls.Add(this.dgvDobavljaci);
            this.Controls.Add(this.lblNazivD);
            this.Controls.Add(this.txtbDobavljacNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPretragaDobavljaca";
            this.Text = "Dobavljači";
            this.Load += new System.EventHandler(this.frmPretragaDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDobavljacNaziv;
        private System.Windows.Forms.Label lblNazivD;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}