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
    
    public partial class esp_Servisi_GetTopFiveByKupacId_Result
    {
        public int ServisID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public bool Popravljeno { get; set; }
        public string Naziv { get; set; }
        public byte[] QRcode { get; set; }
    }
}
