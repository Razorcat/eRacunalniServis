using eRacunalniServis_Servis.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRacunalniServis.Forms.Izvjestaji
{
    public partial class frmReportProizvodi : Form
    {
        public frmReportProizvodi()
        {
            InitializeComponent();            
        }             

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {           
            this.reportViewer1.RefreshReport();
        }
        private void top10Proizvoda()
        {
            List<eRacunalniServis_Servis.Data.esp_Proizvodi_GetPopularne_Result> ds = DAProizvodi.GetPopularneProizvode();
              ReportDataSource rds = new ReportDataSource("DataSetPP", ds);
              reportViewer1.LocalReport.DataSources.Add(rds);
        }
        private void top10NProizvoda()
        {
            List<eRacunalniServis_Servis.Data.esp_Proizvodi_GetTopTenNajprodavanije_Result> ds = DAProizvodi.GetNajProdavanije();
            ReportDataSource rds = new ReportDataSource("dsNP", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
        }

        private void cmbIzvjestaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIzvjestaji.SelectedIndex)
            {
                case 0:
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "eRacunalniServis.Forms.Izvjestaji.rptPopularniProizvodi.rdlc";
                    top10Proizvoda();
                    this.reportViewer1.RefreshReport();
                    break;
                case 1:
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "eRacunalniServis.Forms.Izvjestaji.rptNajprodavanijiProizvodi.rdlc";
                    top10NProizvoda();
                    this.reportViewer1.RefreshReport();
                    break;
                default: 
                    break;
            }
        }
    }
}
