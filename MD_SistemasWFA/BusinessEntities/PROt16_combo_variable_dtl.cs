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
    
    public partial class PROt16_combo_variable_dtl
    {
        public long id_combo_variable_dtl { get; set; }
        public string cod_combo_variable_dtl { get; set; }
        public decimal cantidad { get; set; }
        public decimal mto_pvpu_sin_tax { get; set; }
        public decimal mto_pvpu_con_tax { get; set; }
        public int id_estado { get; set; }
        public string txt_estado { get; set; }
        public int id_combo_variable { get; set; }
        public long id_producto { get; set; }
    
        public virtual PROt09_producto PROt09_producto { get; set; }
        public virtual PROt15_combo_variable PROt15_combo_variable { get; set; }
    }
}
