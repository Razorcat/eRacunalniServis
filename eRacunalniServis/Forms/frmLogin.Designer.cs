namespace eRacunalniServis_Servis.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtbLozinka = new System.Windows.Forms.TextBox();
            this.bntQuit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.toolTipIzlaz = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrijava = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(13, 28);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(104, 18);
            this.lblKorisnickoIme.TabIndex = 3;
            this.lblKorisnickoIme.Text = "Korisničko ime :";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lblLozinka.Location = new System.Drawing.Point(13, 60);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(62, 18);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Lozinka :";
            // 
            // txtbKorisnickoIme
            // 
            this.txtbKorisnickoIme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtbKorisnickoIme.Location = new System.Drawing.Point(123, 25);
            this.txtbKorisnickoIme.MaxLength = 55;
            this.txtbKorisnickoIme.Name = "txtbKorisnickoIme";
            this.txtbKorisnickoIme.Size = new System.Drawing.Size(117, 26);
            this.txtbKorisnickoIme.TabIndex = 0;
            // 
            // txtbLozinka
            // 
            this.txtbLozinka.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtbLozinka.Location = new System.Drawing.Point(123, 57);
            this.txtbLozinka.MaxLength = 55;
            this.txtbLozinka.Name = "txtbLozinka";
            this.txtbLozinka.PasswordChar = '*';
            this.txtbLozinka.Size = new System.Drawing.Size(117, 26);
            this.txtbLozinka.TabIndex = 1;
            // 
            // bntQuit
            // 
            this.bntQuit.BackgroundImage = global::eRacunalniServis.Properties.Resources.Shutdown;
            this.bntQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bntQuit.Location = new System.Drawing.Point(47, 91);
            this.bntQuit.Name = "bntQuit";
            this.bntQuit.Size = new System.Drawing.Size(41, 40);
            this.bntQuit.TabIndex = 5;
            this.toolTipIzlaz.SetToolTip(this.bntQuit, "Izlaz");
            this.bntQuit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::eRacunalniServis.Properties.Resources.login1;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(167, 91);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(51, 41);
            this.btnLogin.TabIndex = 2;
            this.toolTipPrijava.SetToolTip(this.btnLogin, "Prijava na sistem");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntQuit;
            this.ClientSize = new System.Drawing.Size(252, 143);
            this.Controls.Add(this.bntQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbLozinka);
            this.Controls.Add(this.txtbKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eRacunalni servis Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtbKorisnickoIme;
        private System.Windows.Forms.TextBox txtbLozinka;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bntQuit;
        private System.Windows.Forms.ToolTip toolTipIzlaz;
        private System.Windows.Forms.ToolTip toolTipPrijava;
    }
}