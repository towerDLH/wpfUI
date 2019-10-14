namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_fac_stockamt_ms
    {
        [Key]
        public Guid stockamt_id { get; set; }

        public Guid? fac_id { get; set; }

        [StringLength(6)]
        public string stock_month { get; set; }

        public Guid? item_id { get; set; }

        public Guid? location_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? curBalance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? curBalance_Up { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? curBalance_Amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_in_Amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cur_out_Amt { get; set; }

        public DateTime? ladt_del_issue_date { get; set; }

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
    }
}
