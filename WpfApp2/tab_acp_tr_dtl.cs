namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_acp_tr_dtl
    {
        [Key]
        public Guid act_dlt_id { get; set; }

        public Guid? purorderdtl_id { get; set; }

        public decimal? purorder_qty { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? act_id { get; set; }

        public long? std_act_unit_cd { get; set; }

        public Guid? dl_cd { get; set; }

        [StringLength(50)]
        public string dl_no { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? po_id { get; set; }

        public long? po_cls { get; set; }

        public Guid? po_person { get; set; }

        public decimal? acp_amt { get; set; }

        public decimal? tax_amt { get; set; }

        public decimal? acp_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunsi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunbo { get; set; }

        public Guid? acp_unit_cd { get; set; }

        public Guid? std_unit_cd { get; set; }

        public decimal? acp_up { get; set; }

        public decimal? nat_acp_amt { get; set; }

        public decimal? nat_tax_amt { get; set; }

        public decimal? std_acp_qty { get; set; }

        public decimal? std_acpout_qty { get; set; }

        public decimal? std_acp_up { get; set; }

        public Guid? up_unit_cd { get; set; }

        public Guid? curr_cd { get; set; }

        public Guid? nat_curr_cd { get; set; }

        public long? tmp_up_cls { get; set; }

        public long? trade_up_cls { get; set; }

        public long? tax_cls { get; set; }

        public decimal? tax_rate { get; set; }

        public long? tax_charged_cls { get; set; }

        public decimal? nat_rm_amt { get; set; }

        public decimal? rm_up { get; set; }

        public decimal? rm_atm { get; set; }

        public long? rate_cls { get; set; }

        public decimal? rate { get; set; }

        public Guid? pmOutside_cd { get; set; }

        public Guid? producLicence_cd { get; set; }

        public Guid? register_cd { get; set; }

        [StringLength(50)]
        public string picture_cd { get; set; }

        public Guid? location_id { get; set; }

        public int? validflg { get; set; }

        [StringLength(20)]
        public string netpointcode { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? deletetime { get; set; }

        public Guid? deleteuser { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public int autoincr { get; set; }

        public int? pmstatus { get; set; }
    }
}
