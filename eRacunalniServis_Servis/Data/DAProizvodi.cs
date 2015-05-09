using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DAProizvodi
    {
        public static int TotalRows;
        public static void Insert(Proizvodi p){
            Connection.dm.esp_Proizvodi_Insert(p.Naziv,p.Sifra,p.Cijena,p.VrstaID,p.JedinicaMjereID,p.Slika,p.SlikaThumb);            
        }
        public static Object SelectByVrsta(int VrstaId) {
            return Connection.dm.esp_Proizvodi_SelectByVrsta(VrstaId).ToList();
        }
        public static List<VrsteProizvoda> VrsteProizvodaSelectAll() {
            List<VrsteProizvoda> vrste= Connection.dm.esp_VrsteProizvoda_SelectAll().ToList();
            VrsteProizvoda emptyVP = new VrsteProizvoda();
            emptyVP.VrstaID = 0;
            emptyVP.Naziv = "";
            vrste.Insert(0, emptyVP);
            return vrste;
        }
        public static List<JediniceMjere> JediniceMjereSelectAll() {
            List<JediniceMjere> jedinice= Connection.dm.esp_JediniceMjere_SelectAll().ToList();
            JediniceMjere emptyJM = new JediniceMjere();
            emptyJM.JedinicaMjereID = 0;
            emptyJM.Naziv = "";
            jedinice.Insert(0, emptyJM);
            return jedinice;
        }
        public static Object SelectBySifraNaziv(string sifra, string naziv) {
           return Connection.dm.esp_Proizvodi_SelectBySifraNaziv(sifra, naziv).ToList();
        }

        public static List<esp_Proizvodi_SelectBySifraNaziv_Result> SelectBySifraNazivList(string sifra, string naziv)
        {
            return Connection.dm.esp_Proizvodi_SelectBySifraNaziv(sifra, naziv).ToList();
        }
        public static Proizvodi SelectById(int proizvodId) {
            return Connection.dm.esp_Proizvodi_SelectById(proizvodId).FirstOrDefault();
        }



        #region Nabavka
        public static void InsertNabavka(Ulazi ulaz, List<UlazStavke> stavke)
        {
            int ulazId = Convert.ToInt32(Connection.dm.esp_Ulazi_Insert(ulaz.BrojFakture, ulaz.Datum, ulaz.IznosRacuna, ulaz.PDV,
                                           ulaz.Napomena, ulaz.SkladisteID, ulaz.KorisnikID, ulaz.DobavljacID).First());

            foreach (UlazStavke s in stavke)
            {
                Connection.dm.esp_UlazStavke_Insert(ulazId, s.ProizvodID, s.Kolicina, s.Cijena);
            }
        }

        #endregion
        public static List<esp_Proizvodi_SelectByVrstaNaziv_Result> SelectByVrstaNaziv(int VrstaId,string Naziv,int Offset,int MaxRows){
            System.Data.Entity.Core.Objects.ObjectParameter Total = new System.Data.Entity.Core.Objects.ObjectParameter("TotalRows",0);
            List<esp_Proizvodi_SelectByVrstaNaziv_Result> proizvodi= Connection.dm.esp_Proizvodi_SelectByVrstaNaziv(VrstaId, Naziv, Offset, MaxRows, Total).ToList();
            TotalRows = Convert.ToInt32(Total.Value);
            return proizvodi;
        }
    }
}
