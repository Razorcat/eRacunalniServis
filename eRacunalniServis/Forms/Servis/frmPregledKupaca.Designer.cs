namespace eRacunalniServis.Forms.Servis
{
    partial class frmPregledKupaca
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
            this.lblIP = new System.Windows.Forms.Label();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 16);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(101, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "Ime/prezime kupca:";
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNaziv.Location = new System.Drawing.Point(121, 13);
            this.txtbNaziv.MaxLength = 50;
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(377, 20);
            this.txtbNaziv.TabIndex = 1;
            this.txtbNaziv.TextChanged += new System.EventHandler(this.txtbNaziv_TextChanged);
            // 
            // dgvKupci
            // 
            this.dgvKupci.AllowUserToAddRows = false;
            this.dgvKupci.AllowUserToDeleteRows = false;
            this.dgvKupci.AllowUserToOrderColumns = true;
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Location = new System.Drawing.Point(13, 49);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.ReadOnly = true;
            this.dgvKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKupci.Size = new System.Drawing.Size(485, 267);
            this.dgvKupci.TabIndex = 2;
            this.dgvKupci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKupci_CellDoubleClick);
            // 
            // frmPregledKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.dgvKupci);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.lblIP);
            this.Name = "frmPregledKupaca";
            this.Text = "frmPregledKupaca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.DataGridView dgvKupci;
    }
}