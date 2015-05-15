namespace eRacunalniServis.Forms.Kupci
{
    partial class frmKupciIzmjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKupciIzmjene));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtbPotvrdaL = new System.Windows.Forms.TextBox();
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.txtbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.lblPotvrdaL = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDodaj.Location = new System.Drawing.Point(0, 194);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(279, 23);
            this.btnDodaj.TabIndex = 26;
            this.btnDodaj.Text = "Izmjeni podatke";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtbPotvrdaL
            // 
            this.txtbPotvrdaL.Location = new System.Drawing.Point(101, 158);
            this.txtbPotvrdaL.MaxLength = 50;
            this.txtbPotvrdaL.Name = "txtbPotvrdaL";
            this.txtbPotvrdaL.PasswordChar = '*';
            this.txtbPotvrdaL.Size = new System.Drawing.Size(133, 20);
            this.txtbPotvrdaL.TabIndex = 25;
            // 
            // txtbLozinka
            // 
            this.txtbLozinka.Location = new System.Drawing.Point(101, 132);
            this.txtbLozinka.MaxLength = 50;
            this.txtbLozinka.Name = "txtbLozinka";
            this.txtbLozinka.PasswordChar = '*';
            this.txtbLozinka.Size = new System.Drawing.Size(133, 20);
            this.txtbLozinka.TabIndex = 24;
            // 
            // txtbKorisnickoIme
            // 
            this.txtbKorisnickoIme.Location = new System.Drawing.Point(101, 103);
            this.txtbKorisnickoIme.MaxLength = 50;
            this.txtbKorisnickoIme.Name = "txtbKorisnickoIme";
            this.txtbKorisnickoIme.Size = new System.Drawing.Size(133, 20);
            this.txtbKorisnickoIme.TabIndex = 23;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(101, 59);
            this.txtbEmail.MaxLength = 50;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(133, 20);
            this.txtbEmail.TabIndex = 22;
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(101, 33);
            this.txtbPrezime.MaxLength = 50;
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.Size = new System.Drawing.Size(133, 20);
            this.txtbPrezime.TabIndex = 21;
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(101, 7);
            this.txtbIme.MaxLength = 50;
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.Size = new System.Drawing.Size(133, 20);
            this.txtbIme.TabIndex = 20;
            // 
            // lblPotvrdaL
            // 
            this.lblPotvrdaL.AutoSize = true;
            this.lblPotvrdaL.Location = new System.Drawing.Point(12, 161);
            this.lblPotvrdaL.Name = "lblPotvrdaL";
            this.lblPotvrdaL.Size = new System.Drawing.Size(83, 13);
            this.lblPotvrdaL.TabIndex = 19;
            this.lblPotvrdaL.Text = "Potvrda lozinke:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(12, 135);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 18;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 106);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorisnickoIme.TabIndex = 17;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 36);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 15;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 10);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 14;
            this.lblIme.Text = "Ime:";
            // 
            // frmKupciIzmjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 217);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtbPotvrdaL);
            this.Controls.Add(this.txtbLozinka);
            this.Controls.Add(this.txtbKorisnickoIme);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.lblPotvrdaL);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKupciIzmjene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjene podataka o kupcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtbPotvrdaL;
        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.TextBox txtbKorisnickoIme;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.Label lblPotvrdaL;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
    }
}