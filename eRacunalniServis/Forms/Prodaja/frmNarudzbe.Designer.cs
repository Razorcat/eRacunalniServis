namespace eRacunalniServis.Forms.Prodaja
{
    partial class frmNarudzbe
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnPromjeniStatus = new System.Windows.Forms.Button();
            this.btnZatvoriProzor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.AllowUserToOrderColumns = true;
            this.dgvNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(13, 13);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.Size = new System.Drawing.Size(406, 189);
            this.dgvNarudzbe.TabIndex = 0;
            // 
            // btnPromjeniStatus
            // 
            this.btnPromjeniStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPromjeniStatus.Location = new System.Drawing.Point(13, 208);
            this.btnPromjeniStatus.Name = "btnPromjeniStatus";
            this.btnPromjeniStatus.Size = new System.Drawing.Size(75, 38);
            this.btnPromjeniStatus.TabIndex = 1;
            this.btnPromjeniStatus.Text = "Promjeni status";
            this.btnPromjeniStatus.UseVisualStyleBackColor = true;
            // 
            // btnZatvoriProzor
            // 
            this.btnZatvoriProzor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvoriProzor.Location = new System.Drawing.Point(344, 208);
            this.btnZatvoriProzor.Name = "btnZatvoriProzor";
            this.btnZatvoriProzor.Size = new System.Drawing.Size(75, 38);
            this.btnZatvoriProzor.TabIndex = 2;
            this.btnZatvoriProzor.Text = "Zatvori ptozor";
            this.btnZatvoriProzor.UseVisualStyleBackColor = true;
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 257);
            this.Controls.Add(this.btnZatvoriProzor);
            this.Controls.Add(this.btnPromjeniStatus);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "frmNarudzbe";
            this.Text = "frmNarudzbe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnPromjeniStatus;
        private System.Windows.Forms.Button btnZatvoriProzor;
    }
}