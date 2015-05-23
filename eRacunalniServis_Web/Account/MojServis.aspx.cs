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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}