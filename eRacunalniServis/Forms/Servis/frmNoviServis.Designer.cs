namespace eRacunalniServis.Forms.Servis
{
    partial class frmNoviServis
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
            this.pbQRcode = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKupac = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.txtbKupac = new System.Windows.Forms.TextBox();
            this.rtxbOpis = new System.Windows.Forms.RichTextBox();
            this.btnOdaberiKupca = new System.Windows.Forms.Button();
            this.toolTipNaziv = new System.Windows.Forms.ToolTip(this.components);
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQRcode
            // 
            this.pbQRcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQRcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQRcode.Location = new System.Drawing.Point(254, 70);
            this.pbQRcode.Name = "pbQRcode";
            this.pbQRcode.Size = new System.Drawing.Size(134, 122);
            this.pbQRcode.TabIndex = 2;
            this.pbQRcode.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(7, 13);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKupac
            // 
            this.lblKupac.AutoSize = true;
            this.lblKupac.Location = new System.Drawing.Point(7, 43);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(41, 13);
            this.lblKupac.TabIndex = 4;
            this.lblKupac.Text = "Kupac:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(7, 70);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(61, 13);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis kvara:";
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNaziv.Location = new System.Drawing.Point(74, 13);
            this.txtbNaziv.MaxLength = 50;
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(165, 20);
            this.txtbNaziv.TabIndex = 6;
            this.toolTipNaziv.SetToolTip(this.txtbNaziv, "Desktop računalo, lalptop");
            // 
            // txtbKupac
            // 
            this.txtbKupac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbKupac.Location = new System.Drawing.Point(74, 40);
            this.txtbKupac.Name = "txtbKupac";
            this.txtbKupac.ReadOnly = true;
            this.txtbKupac.Size = new System.Drawing.Size(165, 20);
            this.txtbKupac.TabIndex = 7;
            // 
            // rtxbOpis
            // 
            this.rtxbOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbOpis.Location = new System.Drawing.Point(74, 70);
            this.rtxbOpis.Name = "rtxbOpis";
            this.rtxbOpis.Size = new System.Drawing.Size(165, 122);
            this.rtxbOpis.TabIndex = 8;
            this.rtxbOpis.Text = "";
            // 
            // btnOdaberiKupca
            // 
            this.btnOdaberiKupca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdaberiKupca.Location = new System.Drawing.Point(254, 38);
            this.btnOdaberiKupca.Name = "btnOdaberiKupca";
            this.btnOdaberiKupca.Size = new System.Drawing.Size(134, 23);
            this.btnOdaberiKupca.TabIndex = 9;
            this.btnOdaberiKupca.Text = "Odaberi kupca";
            this.btnOdaberiKupca.UseVisualStyleBackColor = true;
            this.btnOdaberiKupca.Click += new System.EventHandler(this.btnOdaberiKupca_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSpremi.Location = new System.Drawing.Point(0, 228);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(400, 23);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNoviServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 251);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdaberiKupca);
            this.Controls.Add(this.rtxbOpis);
            this.Controls.Add(this.txtbKupac);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKupac);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.pbQRcode);
            this.Name = "frmNoviServis";
            this.Text = "frmNoviServis";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRcode;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKupac;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.TextBox txtbKupac;
        private System.Windows.Forms.RichTextBox rtxbOpis;
        private System.Windows.Forms.Button btnOdaberiKupca;
        private System.Windows.Forms.ToolTip toolTipNaziv;
        private System.Windows.Forms.Button btnSpremi;
    }
}