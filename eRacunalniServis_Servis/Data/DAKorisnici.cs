using eRacunalniServis_Servis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;

namespace eRacunalniServis_Servis.Data
{
    public class DAKorisnici
    {
        public static List<Uloge> UlogeSelect() {
            return Connection.dm.esp_Uloge_SelectAll().ToList();
        }
        public static Korisnici SelectByKorisnickoIme(string korisnickoIme, string lozinka) {
            Korisnici k = Connection.dm.esp_Korisnici_SelectByKorisnickoIme(korisnickoIme).FirstOrDefault();
            if(k!=null){
                if (UIHelper.GenerateHash(lozinka, k.LozinkaSalt) == k.LozinkaHash) {
                    k.Uloge = Connection.dm.esp_KorisniciUloge_SelectByKorisnik(k.KorisnikID).ToList();
                    return k;
                }
            }
            return null;
        }

        public static void InsertKorisnik(Korisnici k, List<Uloge> uloge)
        {
            try
            {
                Int32 korisnikID = Convert.ToInt32(Connection.dm.esp_Korisnici_Insert(k.Ime, k.Prezime, k.Email, k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash).First());

                foreach (Uloge u in uloge)
                {
                    Connection.dm.esp_KorisniciUloge_Insert(korisnikID, u.UlogaID);
                }
            }
            catch (EntityException e)
            {
                ExceptionHandler.HandleException(e);
            }
        }

        public static Object SelectByName(string imePrezime)
        {
            return Connection.dm.esp_Korisnici_SelectByName(imePrezime).ToList();
        }
        public static void UpdateStatus(int korisnikID, bool status)
        {
            Connection.dm.esp_Korisnici_UpdateStatus(korisnikID, status);
        }
        public static Korisnici SelectByID(int korisnikID)
        {
            return (Korisnici)Connection.dm.esp_Korisnici_SelectById(korisnikID).First();
        }
        public static void UpdateOsobnihPodataka(Korisnici korisnik) {
            Connection.dm.esp_Korisnici_Update(korisnik.KorisnikID, korisnik.Ime, korisnik.Prezime, korisnik.Email, korisnik.Telefon);
        }
        public static void ResetPassword(Korisnici korisnik) {
            Connection.dm.esp_Korisnici_ResetPass(korisnik.KorisnikID, korisnik.LozinkaSalt, korisnik.LozinkaHash);
        }
        public static void UpdateUloge(int korisnikId, List<Uloge> uloge) {
            Connection.dm.esp_KorisniciUloge_Delete(korisnikId);

            foreach (Uloge u in uloge)
            {
                Connection.dm.esp_KorisniciUloge_Insert(korisnikId, u.UlogaID);
            }
        }
        public static List<Uloge> SelectUloge(int korisnikId) {
            return Connection.dm.esp_KorisniciUloge_SelectByKorisnik(korisnikId).ToList();
        }   
    }
}
