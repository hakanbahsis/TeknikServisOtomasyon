//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServisOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLDEPARTMAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLDEPARTMAN()
        {
            this.TBLPERSONEL = new HashSet<TBLPERSONEL>();
        }
    
        public byte ID { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPERSONEL> TBLPERSONEL { get; set; }
    }
}