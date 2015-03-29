namespace eRacunalniServis_Servis.Forms
{
    partial class frmPretragaProizvoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaProizvoda));
            this.lblNazivProizvoda = new System.Windows.Forms.Label();
            this.txtbNazivProizvoda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNazivProizvoda
            // 
            this.lblNazivProizvoda.AutoSize = true;
            this.lblNazivProizvoda.Location = new System.Drawing.Point(13, 13);
            this.lblNazivProizvoda.Name = "lblNazivProizvoda";
            this.lblNazivProizvoda.Size = new System.Drawing.Size(83, 13);
            this.lblNazivProizvoda.TabIndex = 0;
            this.lblNazivProizvoda.Text = "Naziv proizvoda";
            // 
            // txtbNazivProizvoda
            // 
            this.txtbNazivProizvoda.Location = new System.Drawing.Point(102, 10);
            this.txtbNazivProizvoda.Name = "txtbNazivProizvoda";
            this.txtbNazivProizvoda.Size = new System.Drawing.Size(100, 20);
            this.txtbNazivProizvoda.TabIndex = 1;
            // 
            // frmPretragaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtbNazivProizvoda);
            this.Controls.Add(this.lblNazivProizvoda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPretragaProizvoda";
            this.Text = "frmPretragaProizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivProizvoda;
        private System.Windows.Forms.TextBox txtbNazivProizvoda;
    }
}