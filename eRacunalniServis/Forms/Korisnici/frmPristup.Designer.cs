namespace eRacunalniServis.Forms.Korisnici
{
    partial class frmPristup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPristup));
            this.txtbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.UlogeList = new System.Windows.Forms.CheckedListBox();
            this.chbAkitivan = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtbPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.lblPotvrdaL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbKorisnickoIme
            // 
            resources.ApplyResources(this.txtbKorisnickoIme, "txtbKorisnickoIme");
            this.txtbKorisnickoIme.Name = "txtbKorisnickoIme";
            this.txtbKorisnickoIme.ReadOnly = true;
            // 
            // lblKorisnickoIme
            // 
            resources.ApplyResources(this.lblKorisnickoIme, "lblKorisnickoIme");
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            // 
            // lblLozinka
            // 
            resources.ApplyResources(this.lblLozinka, "lblLozinka");
            this.lblLozinka.Name = "lblLozinka";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtbLozinka
            // 
            resources.ApplyResources(this.txtbLozinka, "txtbLozinka");
            this.txtbLozinka.Name = "txtbLozinka";
            // 
            // UlogeList
            // 
            resources.ApplyResources(this.UlogeList, "UlogeList");
            this.UlogeList.FormattingEnabled = true;
            this.UlogeList.Name = "UlogeList";
            // 
            // chbAkitivan
            // 
            resources.ApplyResources(this.chbAkitivan, "chbAkitivan");
            this.chbAkitivan.Name = "chbAkitivan";
            this.chbAkitivan.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            resources.ApplyResources(this.btnSpremi, "btnSpremi");
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtbPotvrdaLozinke
            // 
            resources.ApplyResources(this.txtbPotvrdaLozinke, "txtbPotvrdaLozinke");
            this.txtbPotvrdaLozinke.Name = "txtbPotvrdaLozinke";
            // 
            // lblPotvrdaL
            // 
            resources.ApplyResources(this.lblPotvrdaL, "lblPotvrdaL");
            this.lblPotvrdaL.Name = "lblPotvrdaL";
            // 
            // frmPristup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbPotvrdaLozinke);
            this.Controls.Add(this.lblPotvrdaL);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.chbAkitivan);
            this.Controls.Add(this.UlogeList);
            this.Controls.Add(this.txtbLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtbKorisnickoIme);
            this.Name = "frmPristup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.CheckedListBox UlogeList;
        private System.Windows.Forms.CheckBox chbAkitivan;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtbPotvrdaLozinke;
        private System.Windows.Forms.Label lblPotvrdaL;
    }
}