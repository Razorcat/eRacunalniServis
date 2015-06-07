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
    public partial class frmReportRacunById : Form
    {
        int izlazID;
        public frmReportRacunById(int IzlazId)
        {
            InitializeComponent();
            izlazID = IzlazId;
        }

        private void frmReportRacunById_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eRacunalniServis.Forms.Izvjestaji.rptRacun.rdlc";
            BindReport(izlazID);            
        }
        private void BindReport(int IzlazId) {
            List<eRacunalniServis_Servis.Data.esp_Izlazi_GetRacunByID_Result> ds = DAIzlazi.GetRacunById(IzlazId);
            ReportDataSource rds = new ReportDataSource("dsGetRacunByID", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("IzlazID_parameter", IzlazId.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
