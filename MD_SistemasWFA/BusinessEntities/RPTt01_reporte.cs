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
    
    public partial class RPTt01_reporte
    {
        public int id_reporte { get; set; }
        public string cod_reporte { get; set; }
        public string txt_desc { get; set; }
        public bool sn_date_range { get; set; }
        public bool sn_rvc_range { get; set; }
        public bool sn_empleado { get; set; }
        public bool sn_clase_empleado { get; set; }
        public bool sn_producto_por_nombre { get; set; }
        public bool sn_producto_por_familia { get; set; }
        public bool sn_producto_por_subfamilia { get; set; }
        public bool sn_turno { get; set; }
        public string txt_path { get; set; }
        public int id_estado { get; set; }
        public string txt_estado { get; set; }
        public int id_categoria_reporte { get; set; }
    
        public virtual RPTt02_categoria_reporte RPTt02_categoria_reporte { get; set; }
    }
}
