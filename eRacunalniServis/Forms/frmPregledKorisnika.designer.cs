namespace eProdaja.Forms
{
    partial class frmPregledKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledKorisnika));
            this.lblImeIPrezime = new System.Windows.Forms.Label();
            this.txtbPretragaByImeP = new System.Windows.Forms.TextBox();
            this.dGVKorisnici = new System.Windows.Forms.DataGridView();
            this.toolStripIzbornik = new System.Windows.Forms.ToolStrip();
            this.btnDeaktiviraj = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.osobniPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKorisnici)).BeginInit();
            this.toolStripIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImeIPrezime
            // 
            this.lblImeIPrezime.AutoSize = true;
            this.lblImeIPrezime.Location = new System.Drawing.Point(12, 16);
            this.lblImeIPrezime.Name = "lblImeIPrezime";
            this.lblImeIPrezime.Size = new System.Drawing.Size(71, 13);
            this.lblImeIPrezime.TabIndex = 0;
            this.lblImeIPrezime.Text = "Ime i prezime:";
            // 
            // txtbPretragaByImeP
            // 
            this.txtbPretragaByImeP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPretragaByImeP.Location = new System.Drawing.Point(89, 13);
            this.txtbPretragaByImeP.Name = "txtbPretragaByImeP";
            this.txtbPretragaByImeP.Size = new System.Drawing.Size(398, 20);
            this.txtbPretragaByImeP.TabIndex = 1;
            this.txtbPretragaByImeP.TextChanged += new System.EventHandler(this.txtbPretragaByImeP_TextChanged);
            // 
            // dGVKorisnici
            // 
            this.dGVKorisnici.AllowUserToAddRows = false;
            this.dGVKorisnici.AllowUserToDeleteRows = false;
            this.dGVKorisnici.AllowUserToOrderColumns = true;
            this.dGVKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKorisnici.Location = new System.Drawing.Point(12, 67);
            this.dGVKorisnici.MultiSelect = false;
            this.dGVKorisnici.Name = "dGVKorisnici";
            this.dGVKorisnici.ReadOnly = true;
            this.dGVKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVKorisnici.Size = new System.Drawing.Size(474, 280);
            this.dGVKorisnici.TabIndex = 2;
            this.dGVKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKorisnici_CellClick);
            // 
            // toolStripIzbornik
            // 
            this.toolStripIzbornik.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeaktiviraj,
            this.toolStripDropDownButton1});
            this.toolStripIzbornik.Location = new System.Drawing.Point(15, 39);
            this.toolStripIzbornik.Name = "toolStripIzbornik";
            this.toolStripIzbornik.Size = new System.Drawing.Size(96, 25);
            this.toolStripIzbornik.TabIndex = 3;
            this.toolStripIzbornik.Text = "Izbornik";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeaktiviraj.Image = global::eRacunalniServis.Properties.Resources.cancel;
            this.btnDeaktiviraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(23, 22);
            this.btnDeaktiviraj.Text = "Deaktiviraj korisnika";
            this.btnDeaktiviraj.ToolTipText = "Deaktiviraj/Aktiviraj korisnika";
            this.btnDeaktiviraj.Click += new System.EventHandler(this.btnDeaktiviraj_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.osobniPodaciToolStripMenuItem,
            this.statusniPodaciToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Izmjene";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // osobniPodaciToolStripMenuItem
            // 
            this.osobniPodaciToolStripMenuItem.Name = "osobniPodaciToolStripMenuItem";
            this.osobniPodaciToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.osobniPodaciToolStripMenuItem.Text = "Osobni podaci";
            // 
            // statusniPodaciToolStripMenuItem
            // 
            this.statusniPodaciToolStripMenuItem.Name = "statusniPodaciToolStripMenuItem";
            this.statusniPodaciToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.statusniPodaciToolStripMenuItem.Text = "Statusni podaci";
            // 
            // frmPregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 359);
            this.Controls.Add(this.toolStripIzbornik);
            this.Controls.Add(this.dGVKorisnici);
            this.Controls.Add(this.txtbPretragaByImeP);
            this.Controls.Add(this.lblImeIPrezime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregledKorisnika";
            this.Text = "Pregled korisnika";
            this.Load += new System.EventHandler(this.frmPregledKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKorisnici)).EndInit();
            this.toolStripIzbornik.ResumeLayout(false);
            this.toolStripIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeIPrezime;
        private System.Windows.Forms.TextBox txtbPretragaByImeP;
        private System.Windows.Forms.DataGridView dGVKorisnici;
        private System.Windows.Forms.ToolStrip toolStripIzbornik;
        private System.Windows.Forms.ToolStripButton btnDeaktiviraj;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem osobniPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusniPodaciToolStripMenuItem;
    }
}