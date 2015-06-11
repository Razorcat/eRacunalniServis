namespace eRacunalniServis.Forms.Izvjestaji
{
    partial class frmReportProizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportProizvodi));
            this.esp_Proizvodi_GetPopularne_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbIzvjestaji = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.esp_Proizvodi_GetPopularne_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // esp_Proizvodi_GetPopularne_ResultBindingSource
            // 
            this.esp_Proizvodi_GetPopularne_ResultBindingSource.DataSource = typeof(eRacunalniServis_Servis.Data.esp_Proizvodi_GetPopularne_Result);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(197, 12);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 21);
            this.btnOsvjezi.TabIndex = 1;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(13, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(259, 211);
            this.reportViewer1.TabIndex = 2;
            // 
            // cmbIzvjestaji
            // 
            this.cmbIzvjestaji.FormattingEnabled = true;
            this.cmbIzvjestaji.Items.AddRange(new object[] {
            "Top 10 proizvoda (ocjena)",
            "Top 10 proizvoda (prodaja)"});
            this.cmbIzvjestaji.Location = new System.Drawing.Point(12, 12);
            this.cmbIzvjestaji.Name = "cmbIzvjestaji";
            this.cmbIzvjestaji.Size = new System.Drawing.Size(178, 21);
            this.cmbIzvjestaji.TabIndex = 3;
            this.cmbIzvjestaji.Text = "Odaberite izvještaj...";
            this.cmbIzvjestaji.SelectedIndexChanged += new System.EventHandler(this.cmbIzvjestaji_SelectedIndexChanged);
            // 
            // frmReportProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbIzvjestaji);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnOsvjezi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportProizvodi";
            this.Text = "Izvještaji o proizvodima";
            ((System.ComponentModel.ISupportInitialize)(this.esp_Proizvodi_GetPopularne_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource esp_Proizvodi_GetPopularne_ResultBindingSource;
        private System.Windows.Forms.Button btnOsvjezi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbIzvjestaji;
    }
}