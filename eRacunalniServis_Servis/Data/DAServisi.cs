using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DAServisi
    {
        public static Int32 GetLastID() {            
             return Convert.ToInt32( Connection.dm.esp_Servisi_GetLastID().Last() );            
        }
         public static void Insert(string Naziv,int KupacId,byte[] QRcode,string Opis ){
            Int32 ServisID = Convert.ToInt32(  Connection.dm.esp_Servisi_Insert(Naziv, KupacId, QRcode).First() );
            DAServisStanje.Insert(ServisID, Opis);
         }
         public static List<Servisi> GetAll() {
             return Connection.dm.esp_Servisi_GetALL().ToList();
         }
         public static Servisi GetById(int ServisId) {
             return Connection.dm.esp_Servis_GetById(ServisId).First();
         }
         public static void UpdatePopravljeno(int servisID, bool popravljeno) {
             Connection.dm.esp_Servis_UpdateStatus(servisID, popravljeno);
         }
        
    }
}
