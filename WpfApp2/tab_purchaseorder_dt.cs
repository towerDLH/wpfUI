namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_purchaseorder_dt
    {
        [Key]
        public Guid purorderdtl_id { get; set; }

        public Guid? dt_purorder_id { get; set; }

        public Guid? purapplicadtl_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purapplica_qty { get; set; }

        public Guid? fac_id { get; set; }

        public Guid? item_id { get; set; }

        public long? item_cls { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        [StringLength(35)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        public long? tax_cls { get; set; }

        public decimal? tax_rate { get; set; }

        public decimal? acpin_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunsi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cnv_rate_bunbo { get; set; }

        public decimal? acp_up { get; set; }

        public decimal? acp_qty { get; set; }

        public Guid? acp_unit { get; set; }

        public decimal? acp_amt { get; set; }

        public decimal? tax_amt { get; set; }

        public decimal? nat_acp_amt { get; set; }

        public decimal? nat_tax_amt { get; set; }

        public Guid? std_unit { get; set; }

        public decimal? std_acp_qty { get; set; }

        public decimal? std_acp_up { get; set; }

        public long? isinvoice { get; set; }

        [StringLength(1024)]
        public string purapp_remark { get; set; }

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

        public int? pmstatus { get; set; }
    }
}
