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
    
    public partial class TNSt04_comp_emitido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TNSt04_comp_emitido()
        {
            this.TNSt05_comp_emitido_dtl = new HashSet<TNSt05_comp_emitido_dtl>();
            this.TNSt07_medio_pago_dtl = new HashSet<TNSt07_medio_pago_dtl>();
            this.TNSt08_descuento_dtl = new HashSet<TNSt08_descuento_dtl>();
            this.TNSt06_comp_emitido_estado = new HashSet<TNSt06_comp_emitido_estado>();
        }
    
        public long id_comp_emitido { get; set; }
        public string nro_comp_emitido { get; set; }
        public int id_tipo_comp { get; set; }
        public long id_cliente { get; set; }
        public Nullable<long> id_empleado { get; set; }
        public Nullable<long> id_emp_autorizador { get; set; }
        public string cod_caja { get; set; }
        public string txt_serie { get; set; }
        public string txt_numero { get; set; }
        public string txt_serie_fe { get; set; }
        public string txt_numero_fe { get; set; }
        public System.DateTime fec_negocio { get; set; }
        public System.DateTime fec_reg_emitido { get; set; }
        public System.DateTime fec_emi { get; set; }
        public Nullable<System.DateTime> fec_vcto { get; set; }
        public Nullable<System.DateTime> fec_canc { get; set; }
        public int id_tipo_moneda { get; set; }
        public int id_can_vta { get; set; }
        public int id_tipo_orden { get; set; }
        public int id_location { get; set; }
        public string txt_observ { get; set; }
        public decimal mto_tc_vta { get; set; }
        public decimal mto_neto { get; set; }
        public decimal mto_exonerado { get; set; }
        public decimal mto_no_afecto { get; set; }
        public decimal mto_dscto_tot { get; set; }
        public decimal mto_servicio { get; set; }
        public decimal mto_sub_tot { get; set; }
        public decimal mto_impto_tot { get; set; }
        public decimal mto_tot_comp { get; set; }
        public Nullable<long> ref_id_comp_emitido { get; set; }
        public string ref_tipo_comprobante { get; set; }
        public Nullable<System.DateTime> ref_fecha { get; set; }
        public string ref_serie { get; set; }
        public string ref_numero { get; set; }
        public Nullable<int> sn_chk_abierto { get; set; }
        public Nullable<int> sn_chk_enviado { get; set; }
        public Nullable<decimal> tax_por01 { get; set; }
        public Nullable<decimal> tax_por02 { get; set; }
        public Nullable<decimal> tax_por03 { get; set; }
        public Nullable<decimal> tax_por04 { get; set; }
        public Nullable<decimal> tax_por05 { get; set; }
        public Nullable<decimal> tax_por06 { get; set; }
        public Nullable<decimal> tax_por07 { get; set; }
        public Nullable<decimal> tax_por08 { get; set; }
        public Nullable<decimal> tax_mto01 { get; set; }
        public Nullable<decimal> tax_mto02 { get; set; }
        public Nullable<decimal> tax_mto03 { get; set; }
        public Nullable<decimal> tax_mto04 { get; set; }
        public Nullable<decimal> tax_mto05 { get; set; }
        public Nullable<decimal> tax_mto06 { get; set; }
        public Nullable<decimal> tax_mto07 { get; set; }
        public Nullable<decimal> tax_mto08 { get; set; }
        public string info01 { get; set; }
        public string info02 { get; set; }
        public string info03 { get; set; }
        public string info04 { get; set; }
        public string info05 { get; set; }
        public string info06 { get; set; }
        public string info07 { get; set; }
        public string info08 { get; set; }
        public string info09 { get; set; }
        public string info10 { get; set; }
        public Nullable<System.DateTime> info_date01 { get; set; }
        public Nullable<System.DateTime> info_date02 { get; set; }
        public Nullable<System.DateTime> info_date03 { get; set; }
        public Nullable<System.DateTime> info_date04 { get; set; }
        public Nullable<System.DateTime> info_date05 { get; set; }
        public Nullable<decimal> info_mto01 { get; set; }
        public Nullable<decimal> info_mto02 { get; set; }
        public Nullable<decimal> info_mto03 { get; set; }
        public Nullable<decimal> info_mto04 { get; set; }
        public Nullable<decimal> info_mto05 { get; set; }
        public Nullable<int> num_comensales { get; set; }
        public Nullable<long> id_usuario { get; set; }
        public string txt_usuario { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<int> id_estado { get; set; }
        public string txt_estado { get; set; }
        public Nullable<int> id_mesa { get; set; }
        public int id_turno { get; set; }
    
        public virtual MSTt03_tipo_orden MSTt03_tipo_orden { get; set; }
        public virtual MSTt04_canal_vta MSTt04_canal_vta { get; set; }
        public virtual MSTt08_location MSTt08_location { get; set; }
        public virtual MSTt13_turno MSTt13_turno { get; set; }
        public virtual MSTt14_mesa MSTt14_mesa { get; set; }
        public virtual PERt01_usuario PERt01_usuario { get; set; }
        public virtual PERt02_cliente PERt02_cliente { get; set; }
        public virtual PERt04_empleado PERt04_empleado { get; set; }
        public virtual PERt04_empleado PERt04_empleado1 { get; set; }
        public virtual SNTt04_tipo_moneda SNTt04_tipo_moneda { get; set; }
        public virtual SNTt10_tipo_comprobante SNTt10_tipo_comprobante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt07_medio_pago_dtl> TNSt07_medio_pago_dtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt08_descuento_dtl> TNSt08_descuento_dtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt06_comp_emitido_estado> TNSt06_comp_emitido_estado { get; set; }
    }
}
