//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EzUtility
{
    using System;
    using System.Collections.Generic;
    
    public partial class ezApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ezApplication()
        {
            this.ezServers = new HashSet<ezServer>();
        }
    
        public int id { get; set; }
        public string Title { get; set; }
        public string ShortName { get; set; }
        public string ServiceCatalogId { get; set; }
        public Nullable<int> ServiceLineId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ezServer> ezServers { get; set; }
        public virtual ezServiceLine ezServiceLine { get; set; }
    }
}
