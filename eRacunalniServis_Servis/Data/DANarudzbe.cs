using eRacunalniServis_Servis.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
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

        public static void InsertNarudzbu(Narudzbe n, List<NarudzbaStavke> narudzbeStavke)
        {
            try
            {
                Int32 narudzbaID = Convert.ToInt32(Connection.dm.esp_Narudzbe_Insert(n.BrojNarudzbe,n.KupacID,n.Datum,n.Status).First());

                foreach (NarudzbaStavke NS in narudzbeStavke)
                {
                    Connection.dm.esp_NarudzbeStavke_Insert(narudzbaID, NS.ProizvodID, NS.Kolicina);
                }
            }
            catch (EntityException e)
            {
                ExceptionHandler.HandleException(e);
            }
        }

        public static List<esp_Narudzbe_SelectAktivneByKupacID_Result> GetAktivneNarudzbeByKupacID(int kupacID)
        {
            return Connection.dm.esp_Narudzbe_SelectAktivneByKupacID(kupacID).ToList();
        }
        public static void OtkaziNarudzbu(int narudzbaID, bool otkazano) {
            Connection.dm.esp_Narudzbe_Otkazi(narudzbaID, otkazano);
        }
    }
}
