using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Data
{
    public partial class Korisnici
    {
        public override string ToString()
        {
            return Ime + "-" + Prezime;
        }
    }
}
