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
    
    public partial class CLIt16_cie10
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt16_cie10()
        {
            this.CLIt15_diagnostico = new HashSet<CLIt15_diagnostico>();
        }
    
        public int id_cie10 { get; set; }
        public string cod_3 { get; set; }
        public string txt_categoria { get; set; }
        public string cod_4 { get; set; }
        public string txt_desc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt15_diagnostico> CLIt15_diagnostico { get; set; }
    }
}