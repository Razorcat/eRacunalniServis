using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public class DADobavljaci
    {
        public static void InsertDobavljaca(Dobavljaci dobavljac) {
            Connection.dm.esp_Dobavljaci_Insert(dobavljac.Naziv, dobavljac.KontaktOsoba, dobavljac.Adresa, dobavljac.Telefon,
                dobavljac.Fax,dobavljac.Web, dobavljac.Email, dobavljac.ZiroRacuni, dobavljac.Napomena);
        }
    }
}
