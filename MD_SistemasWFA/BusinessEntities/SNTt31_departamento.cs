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
    
    public partial class SNTt31_departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt31_departamento()
        {
            this.SNTt32_provincia = new HashSet<SNTt32_provincia>();
        }
    
        public int id_dpto { get; set; }
        public string cod_dpto { get; set; }
        public string cod_dpto_ple { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNTt32_provincia> SNTt32_provincia { get; set; }
    }
}
