namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_rate_ms
    {
        [Key]
        public Guid rate_id { get; set; }

        [StringLength(4)]
        public string rate_code { get; set; }

        public Guid? dl_curr_cd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? eff_sta_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? eff_end_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? realRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        [StringLength(1)]
        public string cnv_method { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entry_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? upd_date { get; set; }

        [StringLength(516)]
        public string remark { get; set; }

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
