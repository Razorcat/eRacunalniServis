namespace eRacunalniServis_Servis.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.glavniMeni = new System.Windows.Forms.MenuStrip();
            this.glavniMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjeniFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nabavaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeSkladištaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaIServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledServisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaProdajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.povijestProdajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administacijaKupacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeSkladištaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPPD = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.glavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniMeni
            // 
            this.glavniMeni.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.glavniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glavniMeniToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.prodajaIServisToolStripMenuItem,
            this.kupciToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.glavniMeni.Location = new System.Drawing.Point(0, 0);
            this.glavniMeni.Name = "glavniMeni";
            this.glavniMeni.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.glavniMeni.Size = new System.Drawing.Size(720, 24);
            this.glavniMeni.TabIndex = 0;
            this.glavniMeni.Text = "glavniMeni";
            // 
            // glavniMeniToolStripMenuItem
            // 
            this.glavniMeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.promjeniFontToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.glavniMeniToolStripMenuItem.Name = "glavniMeniToolStripMenuItem";
            this.glavniMeniToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.glavniMeniToolStripMenuItem.Text = "Glavni meni";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // promjeniFontToolStripMenuItem
            // 
            this.promjeniFontToolStripMenuItem.Name = "promjeniFontToolStripMenuItem";
            this.promjeniFontToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.promjeniFontToolStripMenuItem.Text = "Promjeni font";
            this.promjeniFontToolStripMenuItem.Click += new System.EventHandler(this.promjeniFontToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.pregledKorisnikaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.menuToolStripMenuItem.Text = "Korisnici";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajProizvodToolStripMenuItem,
            this.pretragaProizvodaToolStripMenuItem,
            this.dobavljačiToolStripMenuItem,
            this.nabavaProizvodaToolStripMenuItem,
            this.stanjeSkladištaToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // dodajProizvodToolStripMenuItem
            // 
            this.dodajProizvodToolStripMenuItem.Name = "dodajProizvodToolStripMenuItem";
            this.dodajProizvodToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dodajProizvodToolStripMenuItem.Text = "Dodaj proizvod";
            this.dodajProizvodToolStripMenuItem.Click += new System.EventHandler(this.dodajProizvodToolStripMenuItem_Click_1);
            // 
            // pretragaProizvodaToolStripMenuItem
            // 
            this.pretragaProizvodaToolStripMenuItem.Name = "pretragaProizvodaToolStripMenuItem";
            this.pretragaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pretragaProizvodaToolStripMenuItem.Text = "Pretraga proizvoda";
            this.pretragaProizvodaToolStripMenuItem.Click += new System.EventHandler(this.pretragaProizvodaToolStripMenuItem_Click);
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogDobavljačaToolStripMenuItem,
            this.pretragaDobavljačaToolStripMenuItem});
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            // 
            // dodajNovogDobavljačaToolStripMenuItem
            // 
            this.dodajNovogDobavljačaToolStripMenuItem.Name = "dodajNovogDobavljačaToolStripMenuItem";
            this.dodajNovogDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodajNovogDobavljačaToolStripMenuItem.Text = "Dodaj novog dobavljača";
            this.dodajNovogDobavljačaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogDobavljačaToolStripMenuItem_Click);
            // 
            // pretragaDobavljačaToolStripMenuItem
            // 
            this.pretragaDobavljačaToolStripMenuItem.Name = "pretragaDobavljačaToolStripMenuItem";
            this.pretragaDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pretragaDobavljačaToolStripMenuItem.Text = "Pretraga dobavljača";
            this.pretragaDobavljačaToolStripMenuItem.Click += new System.EventHandler(this.pretragaDobavljačaToolStripMenuItem_Click);
            // 
            // nabavaProizvodaToolStripMenuItem
            // 
            this.nabavaProizvodaToolStripMenuItem.Name = "nabavaProizvodaToolStripMenuItem";
            this.nabavaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nabavaProizvodaToolStripMenuItem.Text = "Nabava proizvoda";
            this.nabavaProizvodaToolStripMenuItem.Click += new System.EventHandler(this.nabavaProizvodaToolStripMenuItem_Click);
            // 
            // stanjeSkladištaToolStripMenuItem
            // 
            this.stanjeSkladištaToolStripMenuItem.Name = "stanjeSkladištaToolStripMenuItem";
            this.stanjeSkladištaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.stanjeSkladištaToolStripMenuItem.Text = "Stanje skladišta";
            this.stanjeSkladištaToolStripMenuItem.Click += new System.EventHandler(this.stanjeSkladištaToolStripMenuItem_Click);
            // 
            // prodajaIServisToolStripMenuItem
            // 
            this.prodajaIServisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servisToolStripMenuItem,
            this.prodajaToolStripMenuItem});
            this.prodajaIServisToolStripMenuItem.Name = "prodajaIServisToolStripMenuItem";
            this.prodajaIServisToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.prodajaIServisToolStripMenuItem.Text = "Prodaja i servis";
            // 
            // servisToolStripMenuItem
            // 
            this.servisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledServisaToolStripMenuItem,
            this.noviServisToolStripMenuItem});
            this.servisToolStripMenuItem.Name = "servisToolStripMenuItem";
            this.servisToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.servisToolStripMenuItem.Text = "Servis";
            // 
            // pregledServisaToolStripMenuItem
            // 
            this.pregledServisaToolStripMenuItem.Name = "pregledServisaToolStripMenuItem";
            this.pregledServisaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pregledServisaToolStripMenuItem.Text = "Pregled servisa";
            this.pregledServisaToolStripMenuItem.Click += new System.EventHandler(this.pregledServisaToolStripMenuItem_Click);
            // 
            // noviServisToolStripMenuItem
            // 
            this.noviServisToolStripMenuItem.Name = "noviServisToolStripMenuItem";
            this.noviServisToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.noviServisToolStripMenuItem.Text = "Novi servis";
            this.noviServisToolStripMenuItem.Click += new System.EventHandler(this.noviServisToolStripMenuItem_Click);
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudžbeToolStripMenuItem,
            this.novaProdajaToolStripMenuItem,
            this.povijestProdajeToolStripMenuItem});
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.prodajaToolStripMenuItem.Text = "Prodaja";
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Click += new System.EventHandler(this.narudžbeToolStripMenuItem_Click);
            // 
            // novaProdajaToolStripMenuItem
            // 
            this.novaProdajaToolStripMenuItem.Name = "novaProdajaToolStripMenuItem";
            this.novaProdajaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.novaProdajaToolStripMenuItem.Text = "Nova prodaja";
            this.novaProdajaToolStripMenuItem.Click += new System.EventHandler(this.novaProdajaToolStripMenuItem_Click);
            // 
            // povijestProdajeToolStripMenuItem
            // 
            this.povijestProdajeToolStripMenuItem.Name = "povijestProdajeToolStripMenuItem";
            this.povijestProdajeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.povijestProdajeToolStripMenuItem.Text = "Povijest prodaje";
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKupcaToolStripMenuItem,
            this.administacijaKupacaToolStripMenuItem});
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.kupciToolStripMenuItem.Text = "Kupci";
            // 
            // dodajKupcaToolStripMenuItem
            // 
            this.dodajKupcaToolStripMenuItem.Name = "dodajKupcaToolStripMenuItem";
            this.dodajKupcaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dodajKupcaToolStripMenuItem.Text = "Dodaj kupca";
            this.dodajKupcaToolStripMenuItem.Click += new System.EventHandler(this.dodajKupcaToolStripMenuItem_Click);
            // 
            // administacijaKupacaToolStripMenuItem
            // 
            this.administacijaKupacaToolStripMenuItem.Name = "administacijaKupacaToolStripMenuItem";
            this.administacijaKupacaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.administacijaKupacaToolStripMenuItem.Text = "Administacija kupaca";
            this.administacijaKupacaToolStripMenuItem.Click += new System.EventHandler(this.administacijaKupacaToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stanjeSkladištaToolStripMenuItem1,
            this.toolStripMenuItemPPD});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // stanjeSkladištaToolStripMenuItem1
            // 
            this.stanjeSkladištaToolStripMenuItem1.Name = "stanjeSkladištaToolStripMenuItem1";
            this.stanjeSkladištaToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.stanjeSkladištaToolStripMenuItem1.Text = "Proizvodi";
            this.stanjeSkladištaToolStripMenuItem1.Click += new System.EventHandler(this.stanjeSkladištaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItemPPD
            // 
            this.toolStripMenuItemPPD.Name = "toolStripMenuItemPPD";
            this.toolStripMenuItemPPD.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemPPD.Text = "Prodaja po datumu";
            this.toolStripMenuItemPPD.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Location = new System.Drawing.Point(329, 232);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(78, 16);
            this.lblDobrodosli.TabIndex = 2;
            this.lblDobrodosli.Text = "Dobrodošli!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 473);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.glavniMeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.glavniMeni;
            this.MinimumSize = new System.Drawing.Size(581, 427);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eRačunalni Servis";
            this.glavniMeni.ResumeLayout(false);
            this.glavniMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip glavniMeni;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glavniMeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjeniFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogDobavljačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaDobavljačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nabavaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaIServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledServisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaProdajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem povijestProdajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administacijaKupacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeSkladištaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeSkladištaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPPD;
    }
}