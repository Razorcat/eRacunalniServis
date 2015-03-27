using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis
{
    public class Global
    {
        public static int brojUloga=0;
        public static eRacunalniServis_Servis.Data.Korisnici prijavljeniKorisnik {get;set;}
        public static string GetString(string key){
            ResourceManager rm=new ResourceManager("eRacunalniServis.Poruke",Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }

    }
}
