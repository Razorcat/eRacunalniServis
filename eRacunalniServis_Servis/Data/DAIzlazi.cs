using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DAIzlazi
    {
        public static List<esp_Izlaz_SelectByDatum_Result> GetProdajuByDatum(DateTime datumOd,DateTime datumDo){
           return Connection.dm.esp_Izlaz_SelectByDatum(datumOd, datumDo).ToList();
        }
        public static List<esp_Izlazi_GetPovijestProdaje_Result> GetPovijestProdaje() {
            return Connection.dm.esp_Izlazi_GetPovijestProdaje().ToList();
        }
    }
}
