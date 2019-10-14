namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_stock_adj_dt
    {
        [Key]
        public Guid adjdt_id { get; set; }

        public Guid? dt_adj_id { get; set; }

        public Guid? fac_id { get; set; }

        public long? adj_cls { get; set; }

        public Guid? item_id { get; set; }

        [StringLength(100)]
        public string item_desc { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        [StringLength(4)]
        public string stock_month { get; set; }

        [StringLength(25)]
        public string seiban { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? adj_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CurBalance { get; set; }

        public Guid? Pinstr_id { get; set; }

        public Guid? adj_unit_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? adj_amt { get; set; }

        public long? adj_reason_no { get; set; }

        public Guid? entry_person { get; set; }

        public DateTime? entry_date { get; set; }

        public Guid? upd_person { get; set; }

        public DateTime? upd_date { get; set; }

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
