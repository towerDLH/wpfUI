namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tab_date_mnth_ms
    {
        [Key]
        public Guid date_mnth_id { get; set; }

        public Guid? fac_id { get; set; }

        public DateTime? today { get; set; }

        [StringLength(6)]
        public string stock_mnth { get; set; }

        public DateTime? stock_start_date { get; set; }

        public DateTime? stock_end_date { get; set; }

        [StringLength(6)]
        public string pur_mnth { get; set; }

        public DateTime? pur_start_date { get; set; }

        public DateTime? pur_end_date { get; set; }

        [StringLength(6)]
        public string sales_mnth { get; set; }

        public DateTime? sales_start_date { get; set; }

        public DateTime? sales_end_date { get; set; }

        [StringLength(6)]
        public string frcast_mnth { get; set; }

        public DateTime? frcast_start_date { get; set; }

        public DateTime? frcast_end_date { get; set; }

        public DateTime? entry_date { get; set; }

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
    }
}
