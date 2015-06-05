using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DAOcjene
    {
        public static int GetOcjenuByKupacID(int kupacID, int proizvodID) { 
            if (Connection.dm.esp_Ocjene_GetOcjenuByKupacId(kupacID, proizvodID).Count()>0)
                return Convert.ToInt32(Connection.dm.esp_Ocjene_GetOcjenuByKupacId(kupacID, proizvodID).First());
            else return 0;
        }
    }
}
