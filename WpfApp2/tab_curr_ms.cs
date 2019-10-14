namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_curr_ms
    {
        [Key]
        public Guid curr_id { get; set; }

        [StringLength(4)]
        public string lang_code { get; set; }

        [StringLength(20)]
        public string curr_desc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unit_price_dgt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? up_dgt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt_dgt { get; set; }

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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int autoincr { get; set; }

        public int? islocalcurrency { get; set; }

        [StringLength(30)]
        public string base_unit { get; set; }
    }
}
