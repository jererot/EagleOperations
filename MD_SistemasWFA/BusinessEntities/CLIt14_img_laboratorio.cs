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
    
    public partial class CLIt14_img_laboratorio
    {
        public long id_img_laboratorio { get; set; }
        public string cod_img_laboratorio { get; set; }
        public Nullable<long> id_laboratorio { get; set; }
        public string txt_path { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
    
        public virtual CLIt13_laboratorio CLIt13_laboratorio { get; set; }
    }
}
