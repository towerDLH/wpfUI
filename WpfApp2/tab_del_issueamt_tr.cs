namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_del_issueamt_tr
    {
        [Key]
        public Guid del_issueamt_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(6)]
        public string year_mnth { get; set; }

        public long del_issueamt_no { get; set; }

        public long? inf_cls { get; set; }

        public long? slip_cls { get; set; }

        public Guid? seq_no { get; set; }

        public long? in_out_cls { get; set; }

        public DateTime? del_issue_date { get; set; }

        public Guid? item_id { get; set; }

        public Guid? proc_id { get; set; }

        public Guid? lot_id { get; set; }

        public long? proc_ptn { get; set; }

        public long? ind_dest_cd { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? in_out_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? up { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        public decimal? tax_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_up { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nat_amt { get; set; }

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
    }
}
