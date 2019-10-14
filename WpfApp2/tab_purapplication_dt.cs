namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_purapplication_dt
    {
        [Key]
        public Guid purapplicadtl_id { get; set; }

        public Guid? dt_purapplica_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(50)]
        public string lot_no { get; set; }

        public Guid? lot_id { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        [StringLength(50)]
        public string item_code { get; set; }

        [StringLength(50)]
        public string item_desc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        public Guid? std_unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purapplica_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CurBalance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purorder_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purinstock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purapplica_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purapplica_up { get; set; }

        public Guid? entry_person { get; set; }

        public DateTime? entry_date { get; set; }

        public int? purapp_status { get; set; }

        [StringLength(1024)]
        public string purapp_remark { get; set; }

        public decimal? pruappAuditNum { get; set; }

        public long? auditStatus { get; set; }

        public int? validflg { get; set; }

        [StringLength(32)]
        public string netpointcode { get; set; }

        public Guid? regdateuser { get; set; }

        public DateTime? regdatetime { get; set; }

        public Guid? updateuser { get; set; }

        public DateTime? updatetime { get; set; }

        public Guid? deleteuser { get; set; }

        public DateTime? deletetime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] lastchanged { get; set; }

        public Guid? acp_unit { get; set; }

        public int? acp_qty { get; set; }
    }
}
