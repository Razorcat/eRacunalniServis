namespace eRacunalniServis.Forms.Servis
{
    partial class frmNoviServisStanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoviServisStanje));
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.grbNSS = new System.Windows.Forms.GroupBox();
            this.rtxtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.grbNSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(14, 16);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Location = new System.Drawing.Point(60, 13);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.ReadOnly = true;
            this.txtbNaziv.Size = new System.Drawing.Size(163, 20);
            this.txtbNaziv.TabIndex = 1;
            // 
            // grbNSS
            // 
            this.grbNSS.Controls.Add(this.rtxtbOpis);
            this.grbNSS.Location = new System.Drawing.Point(17, 53);
            this.grbNSS.Name = "grbNSS";
            this.grbNSS.Size = new System.Drawing.Size(206, 132);
            this.grbNSS.TabIndex = 2;
            this.grbNSS.TabStop = false;
            this.grbNSS.Text = "Novo stanje servisa";
            // 
            // rtxtbOpis
            // 
            this.rtxtbOpis.Location = new System.Drawing.Point(7, 20);
            this.rtxtbOpis.MaxLength = 250;
            this.rtxtbOpis.Name = "rtxtbOpis";
            this.rtxtbOpis.Size = new System.Drawing.Size(193, 106);
            this.rtxtbOpis.TabIndex = 0;
            this.rtxtbOpis.Text = "";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSpremi.Location = new System.Drawing.Point(0, 194);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(244, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNoviServisStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 217);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.grbNSS);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNoviServisStanje";
            this.Text = "Novo stanje servis";
            this.grbNSS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.GroupBox grbNSS;
        private System.Windows.Forms.RichTextBox rtxtbOpis;
        private System.Windows.Forms.Button btnSpremi;
    }
}