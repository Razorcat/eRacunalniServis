using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DANarudzbe
    {
        public static List<esp_Narudzbe_SelectAktivne_Result> GetAktivneNarudzbe()
        {            
            return Connection.dm.esp_Narudzbe_SelectAktivne().ToList();
        }
        public static void UpdateStatus(int narudzbaId, bool status) {
            Connection.dm.esp_Narudzbe_UpdateStatus(narudzbaId, status);        
        }
    }
}
