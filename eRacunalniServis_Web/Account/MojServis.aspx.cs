using eRacunalniServis_Servis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eRacunalniServis_Web.Account
{
    public partial class MojServis : System.Web.UI.Page
    {
        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }
        private List<Servisi> servis;

        protected void Page_Load(object sender, EventArgs e)
        {
             if(!IsPostBack)
                BindServis();            
        }

        private void BindServis()
        {
            if (kupac != null)
            {                
                servis = DAServisi.GetTopFive(kupac.KupacID);
                dgMojiServis.DataSource = servis;
                dgMojiServis.DataBind();
            }
        }

        protected void dgMojiServis_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "cmdDetalji" && kupac != null)
            {
                servis = DAServisi.GetTopFive(kupac.KupacID);
                dgDetaljiServis.DataSource = servis[e.Item.ItemIndex].ServisStanje;                
                dgDetaljiServis.DataBind();
            }
        }
    }
}