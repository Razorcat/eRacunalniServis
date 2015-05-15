using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRacunalniServis_Servis.Data;
using Microsoft.Reporting.WinForms;

namespace eRacunalniServis.Forms.Izvjestaji
{
    public partial class frmReportProdajaByDatum : Form
    {
        public frmReportProdajaByDatum()
        {
            InitializeComponent();
        }

        private void frmReportProdajaByDatum_Load(object sender, EventArgs e)        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eRacunalniServis.Forms.Izvjestaji.rptProdajaDatum.rdlc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<esp_Izlaz_SelectByDatum_Result> ds = new List<esp_Izlaz_SelectByDatum_Result>();
            ds=DAIzlazi.GetProdajuByDatum(dtpDatumOd.Value,dtpDatumDo.Value);
            ReportDataSource rds = new ReportDataSource("DataSetProdajaDatum", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", dtpDatumOd.Value.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", dtpDatumDo.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
