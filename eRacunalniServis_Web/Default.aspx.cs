using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRacunalniServis_Servis.Data;

namespace eRacunalniServis_Web
{
    public partial class _Default : Page
    {
        protected List<VrsteProizvoda> vrste;
        protected List<esp_Proizvodi_SelectByVrstaNaziv_Result> proizvodi;

        public Narudzbe narudzba {
            get { return (Narudzbe)Session["narudzba"]; }
            set { Session["narudzba"] = value; }
        }
        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindVrste();
            BindGrid();           
        }

        private void BindVrste()
        {
            ddlVrstaList.DataSource=DAProizvodi.VrsteProizvodaSelectAll();
            ddlVrstaList.DataBind();
        }

        protected void btnTraziSubmit_Click(object sender, EventArgs e)
        {
            dgProizvodi.CurrentPageIndex = 0;
            BindGrid();
        }

        private void BindGrid()
        {
            int vrstaID = 0;
            if (ddlVrstaList.SelectedIndex != 0)
                vrstaID = Convert.ToInt32(ddlVrstaList.SelectedValue);

            int offset = dgProizvodi.CurrentPageIndex * dgProizvodi.PageSize;
            proizvodi = DAProizvodi.SelectByVrstaNaziv(vrstaID, txtbNazivInput.Text, offset, dgProizvodi.PageSize);
            dgProizvodi.DataSource = proizvodi;

            dgProizvodi.VirtualItemCount = DAProizvodi.TotalRows;
            dgProizvodi.DataBind();
        }

        protected void dgProizvodi_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgProizvodi.CurrentPageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void dgProizvodi_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1) ///
            {
                Image img = (Image)e.Item.FindControl("imgSlikaThumb");
                img.ImageUrl = "~/ImageHandler.ashx?proizvodId=" + proizvodi[e.Item.ItemIndex].ProizvodID;
            }

        }

        protected void dgProizvodi_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "DodajUKopruCmd" && kupac!=null) {
                int proizvodId = Convert.ToInt32(dgProizvodi.DataKeys[e.Item.ItemIndex]);
                TextBox kolicinaInput = (TextBox)e.Item.FindControl("txtbKolicina");
                int kolicina =Convert.ToInt32(kolicinaInput.Text);
                
                if (narudzba == null) {
                    narudzba = new Narudzbe();
                    narudzba.Datum = DateTime.Now;
                    narudzba.BrojNarudzbe = "1/2013";
                    narudzba.KupacID = kupac.KupacID;
                    narudzba.Status = false;
                }
                foreach (NarudzbaStavke s in narudzba.NarudzbaStavke) {
                    if (s.ProizvodID == proizvodId)
                    {
                        s.Kolicina += kolicina;
                        return;
                    }
                }
                NarudzbaStavke stavka = new NarudzbaStavke();
                stavka.ProizvodID = proizvodId;
                stavka.Proizvodi = DAProizvodi.SelectById(proizvodId);
                stavka.Kolicina = kolicina;

                narudzba.NarudzbaStavke.Add(stavka);             
                if (narudzba.NarudzbaStavke.Count > 0)
                    {
                        HyperLink Kosarica = (HyperLink)this.Master.FindControl("hlOrder");
                        Kosarica.Text = string.Format("Moja košarica ({0})", narudzba.NarudzbaStavke.Count);
                    }                                   
            }
        }
        
    }
}