using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRacunalniServis_Servis.Data;

namespace eRacunalniServis_Web.Account
{
    public partial class Login : Page
    {
        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";            

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void loginBox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            kupac = DAKupci.SelectByKorisnickoIme(loginBox.UserName,loginBox.Password);
            try
            {
                if (kupac == null)
                {
                    loginBox.FailureText = "Neispravni podaci ili račun neaktivan!";
                    e.Authenticated = false;
                }
                else
                {
                    e.Authenticated = true;                                       
                }
            }
            catch (Exception ex)
            {
                loginBox.FailureText = ex.Message;
               e.Authenticated = false;
            }
        }
    }
}