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
    
    public partial class PROt09_producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt09_producto()
        {
            this.PROt08_precio_prod = new HashSet<PROt08_precio_prod>();
            this.TNSt02_comp_recibido_dtl = new HashSet<TNSt02_comp_recibido_dtl>();
            this.TNSt05_comp_emitido_dtl = new HashSet<TNSt05_comp_emitido_dtl>();
            this.PROt11_receta_dtl = new HashSet<PROt11_receta_dtl>();
            this.PROt14_combo_fixed_dtl = new HashSet<PROt14_combo_fixed_dtl>();
            this.PROt16_combo_variable_dtl = new HashSet<PROt16_combo_variable_dtl>();
        }
    
        public long id_producto { get; set; }
        public string cod_producto { get; set; }
        public string cod_producto2 { get; set; }
        public string cod_barra { get; set; }
        public string txt_desc { get; set; }
        public Nullable<int> id_um { get; set; }
        public Nullable<int> id_modelo { get; set; }
        public Nullable<decimal> por_impto { get; set; }
        public Nullable<int> id_tipo_moneda { get; set; }
        public Nullable<decimal> mto_pvpu_con_igv { get; set; }
        public Nullable<decimal> mto_pvmi_con_igv { get; set; }
        public Nullable<decimal> mto_pvma_con_igv { get; set; }
        public Nullable<decimal> mto_pvpu_sin_igv { get; set; }
        public Nullable<decimal> mto_pvmi_sin_igv { get; set; }
        public Nullable<decimal> mto_pvma_sin_igv { get; set; }
        public Nullable<decimal> costo_prod { get; set; }
        public string peso_prod { get; set; }
        public string largo_prod { get; set; }
        public string ancho_prod { get; set; }
        public string altura_prod { get; set; }
        public string diametro_prod { get; set; }
        public string url_img_prod { get; set; }
        public string txt_referencia { get; set; }
        public Nullable<int> sn_combo { get; set; }
        public Nullable<int> id_tipo_existencia { get; set; }
        public Nullable<int> id_subfamilia { get; set; }
        public Nullable<int> id_tipo_prod { get; set; }
        public Nullable<int> id_clase_prod { get; set; }
        public Nullable<long> id_receta { get; set; }
        public Nullable<int> sn_exento { get; set; }
        public Nullable<int> sn_inafecto { get; set; }
        public Nullable<int> sn_venta { get; set; }
        public Nullable<int> sn_compra { get; set; }
        public Nullable<int> sn_receta { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
        public Nullable<int> id_impuesto { get; set; }
        public Nullable<long> id_combo { get; set; }
    
        public virtual MSTt06_impuesto MSTt06_impuesto { get; set; }
        public virtual PROt02_modelo PROt02_modelo { get; set; }
        public virtual PROt04_subfamilia PROt04_subfamilia { get; set; }
        public virtual PROt06_clase_prod PROt06_clase_prod { get; set; }
        public virtual PROt07_tipo_prod PROt07_tipo_prod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt08_precio_prod> PROt08_precio_prod { get; set; }
        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }
        public virtual SNTt04_tipo_moneda SNTt04_tipo_moneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt11_receta_dtl> PROt11_receta_dtl { get; set; }
        public virtual SNTt05_tipo_existencia SNTt05_tipo_existencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt14_combo_fixed_dtl> PROt14_combo_fixed_dtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt16_combo_variable_dtl> PROt16_combo_variable_dtl { get; set; }
        public virtual PROt10_receta PROt10_receta { get; set; }
        public virtual PROt13_combo PROt13_combo { get; set; }
    }
}
