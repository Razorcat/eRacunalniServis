//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRacunalniServis_Servis.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skladista
    {
        public Skladista()
        {
            this.Izlazi = new HashSet<Izlazi>();
            this.Ulazi = new HashSet<Ulazi>();
        }
    
        public int SkladisteID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }
    
        public virtual ICollection<Izlazi> Izlazi { get; set; }
        public virtual ICollection<Ulazi> Ulazi { get; set; }
    }
}
