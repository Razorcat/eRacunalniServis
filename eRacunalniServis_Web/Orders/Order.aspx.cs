using eRacunalniServis_Servis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eRacunalniServis_Web.Orders
{
    public partial class Order : System.Web.UI.Page
    {
        public Narudzbe narudzba
        {
            get { return (Narudzbe)Session["narudzba"]; }
            set { Session["narudzba"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvNarudzba.DataSource = narudzba.NarudzbaStavke;
            gvNarudzba.DataBind();
        }
    }
}