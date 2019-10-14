namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_pm_ms
    {
        [Key]
        public Guid item_id { get; set; }

        [StringLength(50)]
        public string item_code { get; set; }

        public Guid? fac_code { get; set; }

        [StringLength(50)]
        public string item_desc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [StringLength(50)]
        public string drw_no { get; set; }

        [StringLength(25)]
        public string seiban { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax_rate { get; set; }

        public long? item_type { get; set; }

        public long? item_type1 { get; set; }

        public long? item_type2 { get; set; }

        public long? item_type3 { get; set; }

        public long? item_type4 { get; set; }

        public long? item_type5 { get; set; }

        public long? item_type6 { get; set; }

        public long? item_type7 { get; set; }

        public long? item_type8 { get; set; }

        public long? item_type9 { get; set; }

        public long? sales_deset { get; set; }

        public Guid? sales_person_cd { get; set; }

        public long? ctrl_cls { get; set; }

        public long? item_cls { get; set; }

        public long? so_alc_cls { get; set; }

        public long? ps_cls { get; set; }

        public long? lot_method { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? frp_period { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lot_qty { get; set; }

        public long? lot_ctrl_cls { get; set; }

        public long? case_ctrl_cls { get; set; }

        public long? stock_cls { get; set; }

        public long? del_sch_cls { get; set; }

        public long? os_alc_cls { get; set; }

        public long? plan_dvd_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? min_lot_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? safe_stock_qty { get; set; }

        public long? use_del_cls { get; set; }

        [StringLength(6)]
        public string trsh_cd { get; set; }

        [StringLength(4)]
        public string std_unit_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? start_seq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? end_seq { get; set; }

        public Guid? std_unit { get; set; }

        public Guid? cnv_unit_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunsi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunbo { get; set; }

        [StringLength(12)]
        public string ship_location { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? net_weight { get; set; }

        public Guid? net_weight_unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? gross_weight { get; set; }

        public Guid? gross_weight_unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? m3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? low_level { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sum_lt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? plan_qty { get; set; }

        public long? proc_ptn { get; set; }

        [StringLength(6)]
        public string maker_cd { get; set; }

        [StringLength(40)]
        public string qry_mtrl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? size1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? size2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? size3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? gravity { get; set; }

        public Guid? prod_fac_cd { get; set; }

        public long? fg_in_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? proc_sum_lt { get; set; }

        [StringLength(4)]
        public string hcdflg { get; set; }

        [StringLength(4)]
        public string spflg { get; set; }

        public long? spexc { get; set; }

        [StringLength(25)]
        public string pmrkey { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pmrver { get; set; }

        public Guid? spname { get; set; }

        public DateTime? spdate { get; set; }

        public long? status { get; set; }

        [StringLength(25)]
        public string sephin { get; set; }

        [StringLength(25)]
        public string ryuhin { get; set; }

        [StringLength(15)]
        public string sakusei { get; set; }

        public Guid? ctrl_section { get; set; }

        public Guid? sales_section { get; set; }

        public Guid? pur_section { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? minsafestock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? expend_lot { get; set; }

        [StringLength(100)]
        public string remark1 { get; set; }

        [StringLength(100)]
        public string remark2 { get; set; }

        [StringLength(100)]
        public string remark3 { get; set; }

        [StringLength(100)]
        public string remark4 { get; set; }

        [StringLength(100)]
        public string remark5 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        public decimal? manualNum { get; set; }

        public int? validflg { get; set; }

        public DateTime? regdatetime { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public Guid? pmcategoryid { get; set; }

        [StringLength(50)]
        public string Abbreviation { get; set; }

        public int? PmType { get; set; }
    }
}
