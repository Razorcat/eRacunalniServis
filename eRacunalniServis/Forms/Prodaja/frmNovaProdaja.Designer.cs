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
            this.grpbKupac = new System.Windows.Forms.GroupBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnOdaberiKupca = new System.Windows.Forms.Button();
            this.grpbKupac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbKupac
            // 
            this.grpbKupac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbKupac.Controls.Add(this.txtbPrezime);
            this.grpbKupac.Controls.Add(this.txtbIme);
            this.grpbKupac.Controls.Add(this.lblPrezime);
            this.grpbKupac.Controls.Add(this.btnNoviKupac);
            this.grpbKupac.Controls.Add(this.lblIme);
            this.grpbKupac.Controls.Add(this.btnOdaberiKupca);
            this.grpbKupac.Location = new System.Drawing.Point(13, 13);
            this.grpbKupac.Name = "grpbKupac";
            this.grpbKupac.Size = new System.Drawing.Size(500, 68);
            this.grpbKupac.TabIndex = 0;
            this.grpbKupac.TabStop = false;
            this.grpbKupac.Text = "Kupac";
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPrezime.Location = new System.Drawing.Point(60, 39);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.ReadOnly = true;
            this.txtbPrezime.Size = new System.Drawing.Size(272, 20);
            this.txtbPrezime.TabIndex = 5;
            // 
            // txtbIme
            // 
            this.txtbIme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIme.Location = new System.Drawing.Point(60, 13);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.ReadOnly = true;
            this.txtbIme.Size = new System.Drawing.Size(272, 20);
            this.txtbIme.TabIndex = 4;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(7, 42);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNoviKupac.Location = new System.Drawing.Point(419, 13);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(75, 46);
            this.btnNoviKupac.TabIndex = 2;
            this.btnNoviKupac.Text = "Novi kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(7, 16);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // btnOdaberiKupca
            // 
            this.btnOdaberiKupca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdaberiKupca.Location = new System.Drawing.Point(338, 13);
            this.btnOdaberiKupca.Name = "btnOdaberiKupca";
            this.btnOdaberiKupca.Size = new System.Drawing.Size(75, 46);
            this.btnOdaberiKupca.TabIndex = 0;
            this.btnOdaberiKupca.Text = "Odaberi kupca";
            this.btnOdaberiKupca.UseVisualStyleBackColor = true;
            this.btnOdaberiKupca.Click += new System.EventHandler(this.btnOdaberiKupca_Click);
            // 
            // frmNovaProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 324);
            this.Controls.Add(this.grpbKupac);
            this.Name = "frmNovaProdaja";
            this.Text = "frmNovaProdaja";
            this.grpbKupac.ResumeLayout(false);
            this.grpbKupac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbKupac;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnOdaberiKupca;

    }
}