using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRacunalniServis_Servis.Data;

namespace eRacunalniServis_Web
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            int proizvodID = Convert.ToInt32(context.Request["proizvodId"]);
            eRacunalniServis_Servis.Data.Proizvodi p = new Proizvodi();

            try
            {
                p = DAProizvodi.SelectById(proizvodID);
            }
            catch (Exception)
            {                
                
            }
            context.Response.ContentType = "image/jpeg";
            if(p.SlikaThumb!=null)
                context.Response.BinaryWrite(p.SlikaThumb);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}