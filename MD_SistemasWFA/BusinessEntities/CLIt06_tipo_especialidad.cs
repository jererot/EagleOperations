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
    
    public partial class CLIt06_tipo_especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt06_tipo_especialidad()
        {
            this.CLIt07_especialidad_medica = new HashSet<CLIt07_especialidad_medica>();
        }
    
        public int id_tipo_especialidad { get; set; }
        public string cod_tipo_especialidad { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt07_especialidad_medica> CLIt07_especialidad_medica { get; set; }
    }
}