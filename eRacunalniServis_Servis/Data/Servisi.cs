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
    
    public partial class Servisi
    {
        public Servisi()
        {
            this.ServisStanje = new HashSet<ServisStanje>();
        }
    
        public int ServisID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
    
        public virtual Kupci Kupci { get; set; }
        public virtual ICollection<ServisStanje> ServisStanje { get; set; }
    }
}
