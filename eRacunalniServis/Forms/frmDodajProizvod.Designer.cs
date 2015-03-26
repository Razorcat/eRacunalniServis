namespace eProdaja.Forms
{
    partial class frmDodajProizvod
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(13, 13);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(87, 227);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(105, 23);
            this.btnDodajProizvod.TabIndex = 1;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            // 
            // frmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmDodajProizvod";
            this.Text = "frmDodajProizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnDodajProizvod;
    }
}