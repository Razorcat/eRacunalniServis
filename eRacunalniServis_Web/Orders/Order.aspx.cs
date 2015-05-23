using eRacunalniServis_Servis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRacunalniServis_Servis.Data;

namespace eRacunalniServis_Web.Orders
{
    public partial class Order : System.Web.UI.Page
    {
        public Narudzbe narudzba
        {
            get { return (Narudzbe)Session["narudzba"]; }
            set { Session["narudzba"] = value; }
        }
        decimal cijena = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {                
                BindGrid();
            }
            txtbCijena.Text = cijena.ToString()+" KM";
        }

        private void BindGrid()
        {
            if(narudzba!=null){
                gvNarudzba.DataSource = narudzba.NarudzbaStavke;
                gvNarudzba.DataBind();               
                foreach (NarudzbaStavke ns in narudzba.NarudzbaStavke) {
                    cijena += ns.Proizvodi.Cijena*ns.Kolicina;
                }
                txtbCijena.Text = cijena.ToString() + " KM";
            }
        }     

        protected void btnZakljuciSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DANarudzbe.InsertNarudzbu(narudzba, narudzba.NarudzbaStavke.ToList());
            }
            catch(Exception ex){
            }
        }   
    }
}