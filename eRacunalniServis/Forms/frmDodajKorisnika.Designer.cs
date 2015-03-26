namespace eProdaja.Forms
{
    partial class frmDodajKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajKorisnika));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtbIme = new System.Windows.Forms.TextBox();
            this.txtbPrezime = new System.Windows.Forms.TextBox();
            this.lblUloge = new System.Windows.Forms.Label();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mtxtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.panelKorisnikPristupUloge = new System.Windows.Forms.Panel();
            this.panelKorisnikPristupUloge.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSpremi.Location = new System.Drawing.Point(0, 277);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(284, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 36);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtbIme
            // 
            this.txtbIme.Location = new System.Drawing.Point(97, 6);
            this.txtbIme.Name = "txtbIme";
            this.txtbIme.Size = new System.Drawing.Size(175, 20);
            this.txtbIme.TabIndex = 3;
            // 
            // txtbPrezime
            // 
            this.txtbPrezime.Location = new System.Drawing.Point(97, 33);
            this.txtbPrezime.Name = "txtbPrezime";
            this.txtbPrezime.Size = new System.Drawing.Size(175, 20);
            this.txtbPrezime.TabIndex = 4;
            // 
            // lblUloge
            // 
            this.lblUloge.AutoSize = true;
            this.lblUloge.Location = new System.Drawing.Point(-1, 59);
            this.lblUloge.Name = "lblUloge";
            this.lblUloge.Size = new System.Drawing.Size(35, 13);
            this.lblUloge.TabIndex = 5;
            this.lblUloge.Text = "Uloge";
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(84, 59);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(175, 64);
            this.ulogeList.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(97, 60);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(175, 20);
            this.txtbEmail.TabIndex = 8;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 90);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // mtxtbTelefon
            // 
            this.mtxtbTelefon.Location = new System.Drawing.Point(97, 87);
            this.mtxtbTelefon.Mask = "(999) 000-000";
            this.mtxtbTelefon.Name = "mtxtbTelefon";
            this.mtxtbTelefon.Size = new System.Drawing.Size(175, 20);
            this.mtxtbTelefon.TabIndex = 10;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(-1, 6);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 11;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(-1, 30);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 12;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtbKorisnickoIme
            // 
            this.txtbKorisnickoIme.Location = new System.Drawing.Point(84, 6);
            this.txtbKorisnickoIme.Name = "txtbKorisnickoIme";
            this.txtbKorisnickoIme.Size = new System.Drawing.Size(175, 20);
            this.txtbKorisnickoIme.TabIndex = 13;
            // 
            // txtbLozinka
            // 
            this.txtbLozinka.Location = new System.Drawing.Point(84, 33);
            this.txtbLozinka.Name = "txtbLozinka";
            this.txtbLozinka.Size = new System.Drawing.Size(175, 20);
            this.txtbLozinka.TabIndex = 14;
            // 
            // panelKorisnikPristupUloge
            // 
            this.panelKorisnikPristupUloge.Controls.Add(this.txtbLozinka);
            this.panelKorisnikPristupUloge.Controls.Add(this.lblUloge);
            this.panelKorisnikPristupUloge.Controls.Add(this.txtbKorisnickoIme);
            this.panelKorisnikPristupUloge.Controls.Add(this.ulogeList);
            this.panelKorisnikPristupUloge.Controls.Add(this.lblLozinka);
            this.panelKorisnikPristupUloge.Controls.Add(this.lblKorisnickoIme);
            this.panelKorisnikPristupUloge.Location = new System.Drawing.Point(12, 130);
            this.panelKorisnikPristupUloge.Name = "panelKorisnikPristupUloge";
            this.panelKorisnikPristupUloge.Size = new System.Drawing.Size(271, 141);
            this.panelKorisnikPristupUloge.TabIndex = 15;
            // 
            // frmDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.panelKorisnikPristupUloge);
            this.Controls.Add(this.mtxtbTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbPrezime);
            this.Controls.Add(this.txtbIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDodajKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajKorisnika";
            this.Load += new System.EventHandler(this.frmDodajKorisnika_Load);
            this.panelKorisnikPristupUloge.ResumeLayout(false);
            this.panelKorisnikPristupUloge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtbIme;
        private System.Windows.Forms.TextBox txtbPrezime;
        private System.Windows.Forms.Label lblUloge;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mtxtbTelefon;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtbKorisnickoIme;
        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.Panel panelKorisnikPristupUloge;
    }
}