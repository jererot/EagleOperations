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
    
    public partial class SNTt10_tipo_comprobante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt10_tipo_comprobante()
        {
            this.FISt01_control_numeracion = new HashSet<FISt01_control_numeracion>();
            this.TNSt01_comp_recibido = new HashSet<TNSt01_comp_recibido>();
            this.TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }
    
        public int id_tipo_comp { get; set; }
        public string cod_tipo_comp { get; set; }
        public string cod_tipo_comp_ple { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_location { get; set; }
        public string cod_location { get; set; }
        public string nro_caja { get; set; }
        public string nro_serie { get; set; }
        public Nullable<long> nro_inicial { get; set; }
        public Nullable<long> nro_final { get; set; }
        public Nullable<long> nro_contador { get; set; }
        public int sn_emito_comp { get; set; }
        public int sn_recibo_comp { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}