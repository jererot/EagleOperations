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
    
    public partial class SNTt14_nacionalidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt14_nacionalidad()
        {
            this.PERt02_cliente = new HashSet<PERt02_cliente>();
            this.PERt03_proveedor = new HashSet<PERt03_proveedor>();
            this.PERt04_empleado = new HashSet<PERt04_empleado>();
        }
    
        public int id_nacionalidad { get; set; }
        public string cod_nacionalidad { get; set; }
        public string cod_nacionalidad_ple { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt02_cliente> PERt02_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt03_proveedor> PERt03_proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt04_empleado> PERt04_empleado { get; set; }
    }
}
