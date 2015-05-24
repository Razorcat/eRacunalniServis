namespace eRacunalniServis.Forms.Servis
{
    partial class frmPregledServisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledServisa));
            this.dgvServisiStanja = new System.Windows.Forms.DataGridView();
            this.dgvServisi = new System.Windows.Forms.DataGridView();
            this.btnPromjeniStanje = new System.Windows.Forms.Button();
            this.BtnDodajNoviZapis = new System.Windows.Forms.Button();
            this.lblKupac = new System.Windows.Forms.Label();
            this.txtbKupac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisiStanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServisiStanja
            // 
            this.dgvServisiStanja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServisiStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisiStanja.Location = new System.Drawing.Point(13, 189);
            this.dgvServisiStanja.Name = "dgvServisiStanja";
            this.dgvServisiStanja.ReadOnly = true;
            this.dgvServisiStanja.Size = new System.Drawing.Size(516, 159);
            this.dgvServisiStanja.TabIndex = 0;
            // 
            // dgvServisi
            // 
            this.dgvServisi.AllowUserToAddRows = false;
            this.dgvServisi.AllowUserToDeleteRows = false;
            this.dgvServisi.AllowUserToOrderColumns = true;
            this.dgvServisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisi.Location = new System.Drawing.Point(12, 13);
            this.dgvServisi.Name = "dgvServisi";
            this.dgvServisi.ReadOnly = true;
            this.dgvServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServisi.Size = new System.Drawing.Size(517, 170);
            this.dgvServisi.TabIndex = 1;
            this.dgvServisi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServisi_CellClick);
            // 
            // btnPromjeniStanje
            // 
            this.btnPromjeniStanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromjeniStanje.Location = new System.Drawing.Point(535, 116);
            this.btnPromjeniStanje.Name = "btnPromjeniStanje";
            this.btnPromjeniStanje.Size = new System.Drawing.Size(100, 67);
            this.btnPromjeniStanje.TabIndex = 2;
            this.btnPromjeniStanje.Text = "Promjeni stanje na popravljeno";
            this.btnPromjeniStanje.UseVisualStyleBackColor = true;
            this.btnPromjeniStanje.Click += new System.EventHandler(this.btnPromjeniStanje_Click);
            // 
            // BtnDodajNoviZapis
            // 
            this.BtnDodajNoviZapis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodajNoviZapis.Location = new System.Drawing.Point(535, 189);
            this.BtnDodajNoviZapis.Name = "BtnDodajNoviZapis";
            this.BtnDodajNoviZapis.Size = new System.Drawing.Size(100, 69);
            this.BtnDodajNoviZapis.TabIndex = 3;
            this.BtnDodajNoviZapis.Text = "Nova bilješka o popravku";
            this.BtnDodajNoviZapis.UseVisualStyleBackColor = true;
            this.BtnDodajNoviZapis.Click += new System.EventHandler(this.BtnDodajNoviZapis_Click);
            // 
            // lblKupac
            // 
            this.lblKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKupac.AutoSize = true;
            this.lblKupac.Location = new System.Drawing.Point(536, 13);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(41, 13);
            this.lblKupac.TabIndex = 4;
            this.lblKupac.Text = "Kupac:";
            // 
            // txtbKupac
            // 
            this.txtbKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbKupac.Location = new System.Drawing.Point(539, 30);
            this.txtbKupac.Name = "txtbKupac";
            this.txtbKupac.ReadOnly = true;
            this.txtbKupac.Size = new System.Drawing.Size(100, 20);
            this.txtbKupac.TabIndex = 5;
            // 
            // frmPregledServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 360);
            this.Controls.Add(this.txtbKupac);
            this.Controls.Add(this.lblKupac);
            this.Controls.Add(this.BtnDodajNoviZapis);
            this.Controls.Add(this.btnPromjeniStanje);
            this.Controls.Add(this.dgvServisi);
            this.Controls.Add(this.dgvServisiStanja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregledServisa";
            this.Text = "Pregled servisa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisiStanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisiStanja;
        private System.Windows.Forms.DataGridView dgvServisi;
        private System.Windows.Forms.Button btnPromjeniStanje;
        private System.Windows.Forms.Button BtnDodajNoviZapis;
        private System.Windows.Forms.Label lblKupac;
        private System.Windows.Forms.TextBox txtbKupac;
    }
}