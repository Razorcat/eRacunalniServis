namespace eRacunalniServis.Forms.Proizvodi
{
    partial class frmStanjeSkladista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanjeSkladista));
            this.dgvSkladisteProizvodi = new System.Windows.Forms.DataGridView();
            this.cmbSkladisteList = new System.Windows.Forms.ComboBox();
            this.lblSkladiste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladisteProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladisteProizvodi
            // 
            this.dgvSkladisteProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSkladisteProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladisteProizvodi.Location = new System.Drawing.Point(12, 37);
            this.dgvSkladisteProizvodi.Name = "dgvSkladisteProizvodi";
            this.dgvSkladisteProizvodi.ReadOnly = true;
            this.dgvSkladisteProizvodi.Size = new System.Drawing.Size(440, 358);
            this.dgvSkladisteProizvodi.TabIndex = 24;
            // 
            // cmbSkladisteList
            // 
            this.cmbSkladisteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkladisteList.FormattingEnabled = true;
            this.cmbSkladisteList.Location = new System.Drawing.Point(68, 8);
            this.cmbSkladisteList.Name = "cmbSkladisteList";
            this.cmbSkladisteList.Size = new System.Drawing.Size(140, 21);
            this.cmbSkladisteList.TabIndex = 22;
            this.cmbSkladisteList.SelectedIndexChanged += new System.EventHandler(this.skladisteList_SelectedIndexChanged);
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(9, 11);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(53, 13);
            this.lblSkladiste.TabIndex = 23;
            this.lblSkladiste.Text = "Skladište:";
            // 
            // frmStanjeSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 407);
            this.Controls.Add(this.dgvSkladisteProizvodi);
            this.Controls.Add(this.cmbSkladisteList);
            this.Controls.Add(this.lblSkladiste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStanjeSkladista";
            this.Text = "Stanje skladista";
            this.Load += new System.EventHandler(this.frmStanjeSkladista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladisteProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkladisteProizvodi;
        private System.Windows.Forms.ComboBox cmbSkladisteList;
        private System.Windows.Forms.Label lblSkladiste;
    }
}