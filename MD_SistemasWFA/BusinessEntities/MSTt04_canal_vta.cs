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
    
    public partial class MSTt04_canal_vta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt04_canal_vta()
        {
            this.FISt01_control_numeracion = new HashSet<FISt01_control_numeracion>();
            this.MSTt14_mesa = new HashSet<MSTt14_mesa>();
            this.TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }
    
        public int id_can_vta { get; set; }
        public string cod_can_vta { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt14_mesa> MSTt14_mesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}