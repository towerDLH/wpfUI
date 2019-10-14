namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_del_issue_tr
    {
        [Key]
        public Guid del_issue_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(6)]
        public string year_mnth { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long del_issue_no { get; set; }

        public long? inf_cls { get; set; }

        public long? slip_cls { get; set; }

        public Guid? seq_no { get; set; }

        public long? item_cls { get; set; }

        public long? in_out_cls { get; set; }

        public DateTime? del_issue_date { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        public long? proc_ptn { get; set; }

        public long? ind_dest_cd { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? now_stock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? in_out_qty { get; set; }

        public Guid? obj_item_id { get; set; }

        public long? obj_proc_ptn { get; set; }

        public Guid? obj_proc_id { get; set; }

        public Guid? obj_seq_no { get; set; }

        public Guid? obj_lot_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? up { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rm_up { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rm_amt { get; set; }

        [StringLength(4)]
        public string act_sbjt { get; set; }

        public Guid? curr_id { get; set; }

        [StringLength(35)]
        public string obj_seiban { get; set; }

        public long? own_cls { get; set; }

        public Guid? dl_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        public Guid? nat_curr_cd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_amt { get; set; }

        public long? rate_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? up_dgt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt_dgt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_amt_dgt { get; set; }

        public Guid? ctrl_section { get; set; }

        public long? stock_cls { get; set; }

        public Guid? obj_fac_id { get; set; }

        [StringLength(6)]
        public string obj_year_mnth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? obj_in_out_qty { get; set; }

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
