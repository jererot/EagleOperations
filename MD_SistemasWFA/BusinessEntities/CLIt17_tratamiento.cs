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
    
    public partial class CLIt17_tratamiento
    {
        public long id_tratamiento { get; set; }
        public string cod_tratamiento { get; set; }
        public string txt_desc { get; set; }
        public Nullable<System.DateTime> fec_negocio { get; set; }
        public Nullable<System.DateTime> fec_registro { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
        public long id_atencion { get; set; }
    
        public virtual CLIt03_atencion CLIt03_atencion { get; set; }
    }
}
