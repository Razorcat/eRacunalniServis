using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DASkladista
    {
        public static List<Skladista> SelectAll()
        {
            List<Skladista> skladista = Connection.dm.Skladista.OrderBy(x => x.Naziv).ToList();

            Skladista empty = new Skladista();
            empty.SkladisteID = 0;
            empty.Naziv = "";
            skladista.Insert(0, empty);

            return skladista;
        }
        public static Object GetStanjeSkladista(int skladisteId) {
            return Connection.dm.esp_Skladista_GetStanjeById(skladisteId).ToList();
        }

    }
}
