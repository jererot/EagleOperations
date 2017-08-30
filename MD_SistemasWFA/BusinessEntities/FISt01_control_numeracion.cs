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
    
    public partial class FISt01_control_numeracion
    {
        public long id_control_numeracion { get; set; }
        public Nullable<int> id_caja { get; set; }
        public Nullable<int> id_can_vta { get; set; }
        public int id_nivel { get; set; }
        public int id_tipo_numeracion { get; set; }
        public int id_tipo_comp { get; set; }
        public string txt_nro_serie { get; set; }
        public Nullable<long> nro_inicial { get; set; }
        public Nullable<long> nro_final { get; set; }
        public Nullable<long> nro_actual { get; set; }
        public string txt_serie_impresora { get; set; }
        public string txt_info01 { get; set; }
        public string txt_info02 { get; set; }
        public Nullable<System.DateTime> fecha01 { get; set; }
        public Nullable<System.DateTime> fecha02 { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<int> locked_by { get; set; }
        public int id_estado { get; set; }
        public string txt_estado { get; set; }
    
        public virtual FISt02_nivel FISt02_nivel { get; set; }
        public virtual FISt03_tipo_numeracion FISt03_tipo_numeracion { get; set; }
        public virtual MSTt04_canal_vta MSTt04_canal_vta { get; set; }
        public virtual MSTt12_caja MSTt12_caja { get; set; }
        public virtual SNTt10_tipo_comprobante SNTt10_tipo_comprobante { get; set; }
    }
}
