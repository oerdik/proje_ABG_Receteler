//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje_ABG_Recete.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UrunList()
        {
            this.BilesenList = new HashSet<BilesenList>();
            this.tblSarjNo = new HashSet<tblSarjNo>();
        }
    
        public short UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string RuhsatSahibi { get; set; }
        public string UrunBoyutu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BilesenList> BilesenList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSarjNo> tblSarjNo { get; set; }
    }
}
