using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DAServisStanje
    {
        public static void Insert(int ServisId, string Opis) {
            Connection.dm.esp_ServisStanje_Insert(ServisId, Opis);
        }
        public static List<ServisStanje> GetAllById(int ServisId) {
            return Connection.dm.esp_ServisStanje_GetAllById(ServisId).ToList();
        }
        public static List<ServisStanje> GetTopFive(int ServisId)
        {
            return Connection.dm.esp_ServisiStanje_GetTopFiveByServisId(ServisId).ToList();
        }
    }
}
