//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROt17_combo_grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt17_combo_grupo()
        {
            this.PROt13_combo = new HashSet<PROt13_combo>();
        }
    
        public int id_combo_grupo { get; set; }
        public string cod_combo_grupo { get; set; }
        public string txt_desc { get; set; }
        public int id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt13_combo> PROt13_combo { get; set; }
    }
}