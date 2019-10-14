namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_fac_stock_ms
    {
        [Key]
        public Guid stock_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        public long? proc_ptn { get; set; }

        public Guid? location_id { get; set; }

        public Guid? lot_id { get; set; }

        public long? own_cls { get; set; }

        [StringLength(12)]
        public string dl_cd { get; set; }

        public DateTime? eff_end_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CurBalance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mnth_start_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_in_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_out_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_adjst_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_loss_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? trn_in_Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? trn_out_Qty { get; set; }

        public DateTime? ladt_del_issue_date { get; set; }

        public DateTime? entry_date { get; set; }

        public DateTime? upd_date { get; set; }

        public int? isJzflg { get; set; }

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
